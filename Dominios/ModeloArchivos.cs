using CapaSoporte.Caché;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
    public class ModeloArchivos
    {
        CacheArchivos archivos = new CacheArchivos();

  

        public bool GuardarArchivo(string nombre, string extension, byte[] file, string usuario)
        {
            return archivos.GuardarArchivo(nombre, extension, file, usuario);
        }

        public bool BorrarArchivos()
        {
            return archivos.BorrarArchivo();
        }

        public DataTable ListarDocs()
        {
            return archivos.ListarDocs();
        }

        public DataTable ArchivoPorId()
        {
            return archivos.ArchivoPorId();
        }


    }
}
