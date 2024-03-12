
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ContextoCarrera
    {
        Acceso_a_Datos.Carrera carrera = new Acceso_a_Datos.Carrera();

        public List<Acceso_a_Datos.Carrera> ListarCarreras()
        {
            return carrera.Carreras();
        }
        public string AgregarCarrera(string nombre, string descripcion)
        {
            return carrera.AgregarCarrera(nombre, descripcion);
        }
        public string ModificarCarrera(string nombre, string descripcion, string idcarrera)
        {
            return carrera.ModificarCarrera(nombre, descripcion, idcarrera);
        }
        public string EliminarCarrera(string idcarrera)
        {
            return carrera.EliminarCarrera(idcarrera);
        }

    }
}
