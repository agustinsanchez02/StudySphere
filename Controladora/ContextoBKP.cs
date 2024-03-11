using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Controladora
{
    public class ContextoBKP
    {
        BKP BKP = new BKP(); 
        public void GenerarBKP()
        {
            BKP.GenerarBKP();
        }
        public void RestaurarBKP()
        {
            BKP.RestaurarBKP();
        }
    }
}
