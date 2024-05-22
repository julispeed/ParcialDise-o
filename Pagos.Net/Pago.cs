using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pagos.Net
{
     public abstract class Pago
    {
        #region StaticAtributes
        private static double importebase=0.01;
        private static int identificacionbase=0;
        private static DateTime fechapagobase = DateTime.MinValue;
        #endregion
        #region Atributes
        protected double importe;
        protected int identificacion;
        protected DateTime fechapago;
        #endregion
        #region Properties
        public double _importe { get { return importe; } set { importe = (value > 0) ? value : importebase; } }
        public int _identificacion { get { return identificacion; } set { identificacion = value > 0 ? value :identificacionbase;} }
        public DateTime _fechapago { get { return fechapago; } set { fechapago = value < DateTime.Now.AddDays(1) ? value : fechapagobase; } }
        #endregion
        #region Constructor        
        public Pago(int identificador, double importe, DateTime fechapago)
        {
            _importe = importe;
            _identificacion = identificador;
            _fechapago = fechapago;
        }
        #endregion
        #region Metodos
        #endregion
        #region Querys
        public override bool Equals(object p)
        {
            bool result = false;
            if (p == null)
                result = (p == this);
            else if (this.GetType()==p.GetType())
            {
                Pago pagotemp = (Pago)p;
                result = pagotemp.identificacion == this.identificacion;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return identificacion*(int)Math.PI;
        }

        public override string ToString()
        {
            return $"Identificacion:{identificacion} - Importe: {importe} - Fecha del pago: {fechapago}";
        }

        public abstract string ObtenerFormaPago();
        #endregion
    }
}