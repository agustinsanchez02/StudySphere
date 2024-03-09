using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class TipoCuenta
    {

        public string Obtenercuenta()
        {
            if (MODELO.Entidades.CacheUsuario.Permisos == 0)
            {
                string TipoCuenta = "Admin";
                return TipoCuenta;
            }
            else
            {
                if (MODELO.Entidades.CacheUsuario.Permisos == 1)
                {
                    string TipoCuenta = "Study Basic";
                    return TipoCuenta;
                }
                else
                {
                    if (MODELO.Entidades.CacheUsuario.Permisos == 2)
                    {
                        string TipoCuenta = "Study Plus";
                        return TipoCuenta;
                    }
                    else
                    {
                        if (MODELO.Entidades.CacheUsuario.Permisos == 3)
                        {
                            string TipoCuenta = "Study Premium";
                            return TipoCuenta;
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }

        }
    }
}
