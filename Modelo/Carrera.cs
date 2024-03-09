using System;
using System.Collections.Generic;

namespace MODELO.Entidades
{
    public partial class Carrera
    {

        public static int Idcarrera { get; set; }
        public static string Nombre { get; set; }
        public static string Descripcion { get; set; }

        public Carrera(int idcarrera, string nombre, string descripcion)
        {
            Idcarrera = idcarrera;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public Carrera()
        {
        }
    }
}
