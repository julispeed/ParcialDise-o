using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagos.Net
{
    public partial class IngresarPago : Form
    {
        #region Constructor
        public IngresarPago()
        {            
            InitializeComponent();
            //definimos parametros para que no tengamos no seleccionados
            CBFinanciacion.SelectedIndex = 0;
        }
        #endregion

        #region Click

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BIngresar_Click(object sender, EventArgs e)
        {
            Pago pago=null;
            //  corroboramos parametros y mandamos mensaje del campo especifico a completar
            if (!MTImporte.MaskCompleted)
            {
                MessageBox.Show("Debe ingresar un importe válido, los campos de centavos y unidad deben completarse como mínmio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!MTNumPago.MaskCompleted)
            {
                MessageBox.Show("Debe ingresar numero de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDateTime(DTFechaPago.Value) > DateTime.Now)
            {
                MessageBox.Show("La Fecha de pago debe ser anterior a mañana", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            //corroboramos los radio buttons y en base a esto proseguimos
            else if (RBTrans.Checked)
            {
                if (!MTNumOp.MaskCompleted)
                    MessageBox.Show("El numero de Operacion debe ser válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!MTCVU.MaskFull)
                    MessageBox.Show("El CVU debe ser válido");
                else if (!((MTCUIT.MaskFull) && EsCuitValido(MTCUIT.Text.Replace("-", ""))))
                    MessageBox.Show("No es un CUIT válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //esta es una instancia válida para instanciar un objeto
                    pago = new Transferencia(MTNumOp.Text, MTCUIT.Text,MTCVU.Text, Convert.ToInt32(MTNumPago.Text), Convert.ToDouble(MTImporte.Text), Convert.ToDateTime(DTFechaPago.Value));                    
                }
            }
            else if (RBTarj.Checked)
            {
                if (!MTNumCupon.MaskCompleted)
                    MessageBox.Show("El numero de cupon debe ser válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (TBBanco.Text == "")
                    MessageBox.Show("Debe ingresar un banco");
                else if (TBServicio.Text == "")
                    MessageBox.Show("debe ingresar un servicio");
                else 
                {
                    //esta es una instancia válida para instanciar un objeto
                    pago = new PTarjeta(Convert.ToInt32(MTNumCupon.Text),TBBanco.Text,TBServicio.Text,CBFinanciacion.Text,Convert.ToBoolean(CHacreditado.Checked) ,Convert.ToInt32(MTNumPago.Text), Convert.ToDouble(MTImporte.Text), Convert.ToDateTime(DTFechaPago.Value));                    
                }
            }
            else
            {
                // si no es ni transferencia ni tarjeta entonces es efectivo
                pago = new Efectivo(Convert.ToInt32(MTNumPago.Text),Convert.ToDouble(MTImporte.Text), Convert.ToDateTime(DTFechaPago.Value));                
            }
            // agregamos el pago con el metodo agregar de Coleccion.
            if (pago != null)
                AgregarPago(pago);
            //limpiamos campos para agregar otro pago
            LimpiarCampos();

        }
        #endregion
        #region Changes
        private void RBEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBEfectivo.Checked)
            {
                PTarjeta.Visible = false;
                Ptrans.Visible = false;
            }            
        }

        private void RBTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTrans.Checked)
            {
                Ptrans.Visible = true;
                PTarjeta.Visible = false;
            }
        }


        private void RBTarj_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTarj.Checked)
            {
                PTarjeta.Visible = true;
                Ptrans.Visible = false;
            }
        }
        #endregion
        #region Consultas
        //consulta para traer la desicion del usuario
        public bool DeseaActualizar(Pago pago)
        {
            return MessageBox.Show($"Se encontró:\n\n{pago.ToString()}\n\n¿Desea actualizarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        //consulta para saber si el cuit de la transferencia es válido
        static bool EsCuitValido(string cuit)
        {            
            if (cuit.Length != 11 || !long.TryParse(cuit, out _))
            {
                return false;
            }

            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;            

            for (int i = 0; i < 10; i++)
            {
                suma += int.Parse(cuit[i].ToString()) * multiplicadores[i];
            }

            int mod = suma % 11;
            int digitoVerificador = 11 - mod;

            if (digitoVerificador == 11) digitoVerificador = 0;
            else if (digitoVerificador == 10) digitoVerificador = 9;
            
            return digitoVerificador == int.Parse(cuit[10].ToString());
        }
        #endregion
        #region Metodos
        //metodo donde se agrega un pago que sabemos que tiene parametros válidos pero no si ta ha sido ingresado
        public bool AgregarPago(Pago p)
        {
            bool result = false;            
            // usamos el metodo de coleccion para saber si esta repetido
            if (!InterfazPagos.pagos.EsRepetido(p, out int i))
            {
                //si entra aqui sabemos que no lo esta
                InterfazPagos.pagos.AgregarPago(p);
                MessageBox.Show("Pago Ingresado Correctamente","OK",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
            else
            {
                //si entra aqui sabemos que existe y consultamos sobre su actualizacion
                //bool mismoTipo = InterfazPagos.pagos.GetType() == p.GetType();
                if (DeseaActualizar(InterfazPagos.pagos._pagos[i]))
                {
                    InterfazPagos.pagos.Modificar(i, p);
                    MessageBox.Show(p.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            return result;
        }


        //limpia los campos
        private void LimpiarCampos()
        {
            MTCUIT.Clear();
            MTCVU.Clear();
            MTImporte.Clear();
            MTNumCupon.Clear();
            MTNumOp.Clear();
            MTNumPago.Clear();
            TBBanco.Text = "";
            TBServicio.Text = "";
        }
        #endregion

    }
}
