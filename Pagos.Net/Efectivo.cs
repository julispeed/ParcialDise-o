using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagos.Net
{
    public class Efectivo : Pago
    {
        #region

        #endregion

        #region Constructor
        public Efectivo(int identificador, double importe, DateTime fechapago) : base(identificador, importe, fechapago)
        {
        }
        #endregion

        public override bool Equals(object e)
        {
            bool result = false;
            if (e == null)
            {
                return e == this;
            }
            else
            {
                Efectivo etemp = (Efectivo)e;
                result = (this._identificacion == etemp._identificacion);
            }
            return result;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        #region 
        #endregion
        public override string ObtenerFormaPago()
        {
            return "Efectivo";
        }

        public override string ToString()
        {
            return base.ToString()+" "+ObtenerFormaPago();
        }
    }
}
