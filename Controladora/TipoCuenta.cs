using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class TipoCuenta
    {
        Acceso_a_Datos.TipoCuenta tipoCuenta = new Acceso_a_Datos.TipoCuenta();
        public string ObtenerTipoCuenta()
        {
            return tipoCuenta.Obtenercuenta();
        }

    }
}
