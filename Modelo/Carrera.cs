using System;
using System.Collections.Generic;

namespace MODELO.Entidades
{
    public partial class Carrera
    {

        public  int Idcarrera { get; set; }
        public  string Nombre { get; set; }
        public  string Descripcion { get; set; }

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
