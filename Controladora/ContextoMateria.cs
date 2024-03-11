using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ContextoMateria
    {
        Acceso_a_Datos.Materias materia = new Acceso_a_Datos.Materias();

        public List<Acceso_a_Datos.Materias> ListarMaterias()
        {
            return materia.materias();
        }
        public string AgregarMateria(string nombre, string descripcion)
        {
            return materia.AgregarMateria(nombre, descripcion);
        }
        public string ModificarMateria(string nombre, string descripcion, string idmateria)
        {
            return materia.ModificarMateria(nombre, descripcion, idmateria);
        }
        public string EliminarMateria(string idmateria)
        {
            return materia.EliminarMateria(idmateria);
        }
    }
}
