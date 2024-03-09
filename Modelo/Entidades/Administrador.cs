using System;
using System.Collections.Generic;

namespace MODELO.Entidades
{
    public partial class Administrador : Usuario
    {

        public static int Idadmin { get; set; }
        public  static int Idusuario { get; set; }

        public Administrador()
        {
        }

        public Administrador(int idadmin, int idusuario)
        {
            Idadmin = idadmin;
            Idusuario = idusuario;
        }

    }
}
