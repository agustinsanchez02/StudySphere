using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte.Caché
{
    public class TipoCuenta
    {
        public string Obtenercuenta()
        {
            if(CacheUsuario.Privilegios == 0)
            {
                string TipoCuenta = "Admin";
                return TipoCuenta;
            }
            else 
            {
                if (CacheUsuario.Privilegios == 1)
                {
                    string TipoCuenta = "Study Basic";
                    return TipoCuenta;
                }
                else
                {
                    if (CacheUsuario.Privilegios == 2)
                    {
                        string TipoCuenta = "Study Plus";
                        return TipoCuenta;
                    }
                    else
                    {
                        if (CacheUsuario.Privilegios == 3)
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
