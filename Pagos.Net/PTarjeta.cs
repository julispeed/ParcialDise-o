using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagos.Net
{
    public class PTarjeta : Pago
    {
        #region Static Atributres
        private static int numcuponbase = 0;
        private string bancobase="";
        private string serviciobase = "";
        private string financiacionbase="";
        private bool acreditadobase = false;
        #endregion
        #region Atributes
        private int numcupon;
        private string banco;
        private string servicio;
        private string financiacion;
        private bool acreditado;
        #endregion
        #region Properties
        public bool _acreditado { get { return acreditado;} set { acreditado = (value != null) ? value : acreditadobase; } }
        public int _numcupon { get { return numcupon; } set { numcupon = (value > 0) ? value : numcuponbase; } }
        public string _banco { get { return banco; } set { banco = (value.Length > 1) ? value : bancobase; } }
        public string _servicio { get {return servicio; } set { servicio = (value.Length> 1) ? value : serviciobase; } }
        public string _financiacion { get { return financiacion; } set { financiacion = (value.Length == 6) || (value.Length == 7) ? value : financiacionbase;} }
        #endregion
        #region Constructor
        public PTarjeta(int numcupon, string banco, string servicio, string financiacion,bool acreditacion,int identificador, double importe, DateTime fechapago) : base(identificador, importe, fechapago)
        {
            _numcupon = numcupon;
            _banco = banco;
            _servicio = servicio;
            _financiacion = financiacion;
            _acreditado = acreditacion;
        }
        #endregion
        #region Methods
        #endregion
        #region Querys        
        public override bool Equals(object p)
        {
            bool result = false;
            if (p == null)
                result = (this == null);
            else if (this.GetType() == p.GetType())
            {
                PTarjeta ptemp = (PTarjeta)p;
                result= (this._identificacion == ptemp._identificacion || (this._numcupon== ptemp._numcupon) && (this.servicio==ptemp.servicio));
            }

            return result;
        }
        public override string ToString()
        {
            return base.ToString() + $"- Numero Cupon: {numcupon} - Banco: {banco} - Servicio:{servicio} - Financiacion: {financiacion} - Acreditado:{acreditado}";
        }

        public override int GetHashCode()
        {
            return this._identificacion*this.numcupon;
        }

        public override string ObtenerFormaPago()
        {
            return $"Tarjeta de {financiacion}";
        }

        #endregion
    }
}
