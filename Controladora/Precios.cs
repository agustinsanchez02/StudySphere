using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Precios
    {
        Acceso_a_Datos.Precios precio = new Acceso_a_Datos.Precios();
        public int obtenerPrecioM()
        {
            return precio.ObtenerPrecioM();
        }
        public int ObtenerPrecioA()
        {
            return precio.ObtenerPrecioA();
        }
        public int SobreEscribirPrecioM(int Precio)
        {
            return precio.SobreEscribirPrecioM(Precio);
        }
        public int SobreEscribirPrecioA(int Precio)
        {
            return precio.SobreEscribirPrecioA(Precio);
        }
    }
}
