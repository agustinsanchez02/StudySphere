using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ContextoArchivo
    {
        Acceso_a_Datos.Archivo archivos = new Acceso_a_Datos.Archivo();

        public List<Acceso_a_Datos.Archivo> Filtrodocumentos(int id)
        {
            return archivos.Filtrodocumentos(id);
        }
       
        public bool GuardarArchivo(string nombre, int tamaño ,string extension, byte[] file, int IDUsuario, string materia, string carrera)
        {
            return archivos.GuardarArchivo(nombre,tamaño ,extension, file, IDUsuario, materia, carrera);
        }

        public bool BorrarArchivos(int id)
        {
            return archivos.BorrarArchivo(id);
        }

        public DataTable ListarDocs()
        {
            return archivos.ListarDocs();
        }
        public DataTable FiltroArchivo(string texto)
        {
            return archivos.FiltroArchivo(texto);
        }
    }
}
