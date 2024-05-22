using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Pagos.Net
{
    public class Coleccion
    {
        #region Atributes
        private static List<Pago> pagos;
        #endregion
        #region Propiedades
        public List<Pago> _pagos { get { return pagos; } set { pagos = value;} }
        #endregion
        #region Constructor
        public Coleccion()
        {
            pagos= new List<Pago>();
        }
        #endregion
        #region metodos
        public void AgregarPago(Pago pago)
        {
            pagos.Add(pago);
        }
        public bool Eliminar(int identificador)
        {
            bool eliminado = false;
            int i = 0;
            while (!eliminado && i < pagos.Count)
            {
                if (pagos[i]._identificacion == identificador)
                {
                    pagos.Remove(pagos[i]);
                    eliminado = true;
                }
            }
            return eliminado;
        }
        public void Modificar(int i, Pago p)
        {
            if (p != null)
                pagos[i] = p;
        }
        #endregion
        #region Consultas
        public Pago Encontrar(string numop)
        {
            Transferencia pago = null;
            foreach (Transferencia p in pagos)
            {
                if (p._numoperacion == numop)
                    pago = p;
            }
            return pago;
        }
        public  Pago Encontrar(int numcupon, string servicio)
        {
            PTarjeta pago = null;
            foreach (PTarjeta p in pagos)
            {
                if ((p._numcupon == numcupon) && (servicio==p._servicio))
                    pago = p;
            }
            return pago;
        }

        public Pago Encontrar(int identificador)
        {
            Pago pago = null;
            foreach (Pago p in pagos)
            {
                if (p._identificacion == identificador)
                    pago = p;
            }
            return pago;
        }
        public bool EsRepetido(Pago p, out int pos)
        {
            {
                int i = 0;
                bool result = false;

                while (i < pagos.Count && !result)
                {
                    if ((p is Efectivo efectivo1) && (pagos[i] is Efectivo efectivo2) && (efectivo1._identificacion == efectivo2._identificacion))
                        result = true;

                    else if ((p is PTarjeta cupon1) && (pagos[i] is PTarjeta cupon2) && (cupon1.Equals(cupon2)))// Debido a que puede haber un numero de cupon repetido si son de distinto servicio.
                        result = true;

                    else if ((p is Transferencia transferencia1) && (pagos[i] is Transferencia transferencia2) && (transferencia1._numoperacion == transferencia2._numoperacion))
                        result = true;
                    else if (pagos[i]._identificacion == p._identificacion)
                        result = true;
                    i++;
                }

                pos = result ? i - 1 : -1;
                return result;
            }
        }
        #endregion

    }
}
