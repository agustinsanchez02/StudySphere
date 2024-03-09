using System;
using System.Collections.Generic;

namespace MODELO.Entidades
{
    public partial class Materia
    {
        public static int Idmateria { get; set; }
        public static string Materias { get; set; }

        public Materia(int idmateria, string materia)
        {
            Idmateria = idmateria;
            Materias = materia;
        }

        public Materia()
        {
        }
        
    }
}
