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
    public partial class InterfazPagos : Form
    {
        #region Atributes      
        
        public static Coleccion pagos;
        #endregion
        #region Constructor
        public InterfazPagos()
        {     
            //instanciamos pagos
            pagos = new Coleccion();
            InitializeComponent();
            //definimos parametros para que no tengmos no seleccinados
            CBFiltro.SelectedIndex = 0;
            RBIdentificador.Checked = true;
        }
        #endregion
        #region exit
        private void Bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Click
        private void BAgregar_Click(object sender, EventArgs e)
        {
            Form IngresodePago = new IngresarPago();
            IngresodePago.ShowDialog();
            ListarLista();
        }
        private void BAcercaDe_Click(object sender, EventArgs e)
        {
            Form IngresodePago = new AcercaDe();
            IngresodePago.ShowDialog();
        }


        private void Beliminar_Click(object sender, EventArgs e)
        {
            if (MTidEliminar.Text == "")
            {
                MessageBox.Show("Ingresar un identificador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!pagos.Eliminar(Convert.ToInt32(MTidEliminar.Text)))
            {
                MessageBox.Show($"El pago con el identificador {MTidEliminar.Text} no existe");
            }
            else
            {
                MessageBox.Show("Pago eliminado");
                ListarLista();
            }
        }
        private void Bbuscar_Click(object sender, EventArgs e)
        {

            if (RBNUMOP.Checked)
            {
                if (!MTNumOp.MaskFull)
                {
                    MessageBox.Show("Debe ingresar un numero de operacion valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Pago p = pagos.Encontrar(MTNumOp.Text);
                    if (p != null)
                        MessageBox.Show(p.ToString());
                    else
                        MessageBox.Show("No se encontro el Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RBNumCupon.Checked)
            {
                if (!MTNumCupon.MaskCompleted || (TBServicio.Text == "Servicio"))
                {
                    MessageBox.Show("Debe ingresar un numero de cupon y servicio valido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Pago p = pagos.Encontrar(Convert.ToInt32(MTNumCupon.Text), TBServicio.Text);
                    if (p != null)
                        MessageBox.Show(p.ToString());
                    else
                        MessageBox.Show("No se encontro el Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RBIdentificador.Checked)
            {
                if (!MTID.MaskCompleted)
                {
                    MessageBox.Show("Debe ingresar un identificador validp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Pago p = pagos.Encontrar(Convert.ToInt32(MTID.Text));
                    if (p != null)
                        MessageBox.Show(p.ToString());
                    else
                        MessageBox.Show("No se encontro el Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Metodos
        public void ListarLista()
        {
            // limpiamos el listbox y ordenamos la lista
            LBpagos.Items.Clear();
            Ordenar();
            int index = CBFiltro.SelectedIndex;
            //foreach para listar en base al valor boleano definido por el combobox
            foreach (Pago p in pagos._pagos)
            {
                bool mostrarp = false;

                switch (index)
                {
                    case 0: // TODOS
                        mostrarp = true;
                        break;
                    case 1: // Efectivo
                        mostrarp = p is Efectivo;
                        break;
                    case 2: // transferencias
                        mostrarp = p is Transferencia;
                        break;
                    case 3: // cupones
                        mostrarp = p is PTarjeta;
                        break;
                    default:
                        mostrarp= true;
                        break;
                }

                if (mostrarp)
                    LBpagos.Items.Add(p.ToString());
            }
            //actualizamos la cantidad de pagos segun los listados
            LCantidad.Text = $"Cantidad: {LBpagos.Items.Count}";

        }
        public void Ordenar()
        {            
            //ordenamos segun fecha
            pagos._pagos.OrderBy(p => p._fechapago).ToList();
        }
        #endregion
        #region Changes       
        private void CBFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarLista();
        }
        #endregion     
    }
}
