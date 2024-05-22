using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pagos.Net
{
    public class Transferencia:Pago
    {
        #region Atributos estaticos
        private static string numoperacionbase="0";
        private static string cuitemisorbase = "11111111111";//cuit habilitado para consumidor final.
        private static string cvuorigenbase ="1";
        #endregion
        #region Atributos

        private string numoperacion;
        private string cuitemisor;
        private string cvuorigen;

        public Transferencia(string numoperacion, string cuitemisor, string cvuorigen, int identificador, double importe, DateTime fechapago) : base(identificador, importe, fechapago)
        {
            _numoperacion = numoperacion;
            _cuitemisor = cuitemisor;
            _cvuorigen = cvuorigen;
        }

        #endregion

        #region Properties
        public string _numoperacion { get { return numoperacion; } set { numoperacion = value.Length==20 ? value:numoperacionbase; } }
        public string _cuitemisor { get { return cuitemisor; } set { cuitemisor = (value.Length == 13) ? value : cuitemisorbase; } }
        public string _cvuorigen { get { return cvuorigen; } set { cvuorigen = value.Length == 22 ? value : cvuorigenbase; } }

        public override bool Equals(object t)
        {
            bool result = false;
            if (t == null)
            {
                return t == this;
            }
            else
            {
                Transferencia Ttemp = (Transferencia)t;
                result = (this._identificacion == Ttemp._identificacion);
            }
            return result;
        }

        public override int GetHashCode()
        {
            
            return this.GetHashCode();
        }
        #endregion

        #region Querys
        public override string ObtenerFormaPago()
        {
            return "Transferencia";
        }

        public override string ToString()
        {
            return base.ToString()+ $"Numero de operacion: {numoperacion} - Cuit Emisor: {cuitemisor} - CBU/CVU orgien: {cvuorigen}";
        }

        #endregion

    }
}
