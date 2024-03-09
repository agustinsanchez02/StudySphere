using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class Precios
    {
        public int ObtenerPrecioM()
        {
            return MODELO.Entidades.Precios.precioM;
        }
        public int ObtenerPrecioA()
        {
            return MODELO.Entidades.Precios.precioA;
        }
        public int SobreEscribirPrecioM(int precio)
        {
            MODELO.Entidades.Precios.precioM = precio;
            return precio;
        }
        public int SobreEscribirPrecioA(int precio)
        {
            MODELO.Entidades.Precios.precioA = precio;
            return precio;
        }
    }
}
