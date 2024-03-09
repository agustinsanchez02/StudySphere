using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MODELO.Entidades
{
    public class Usuario
    {
        public Usuario()
        {

        }

        public  int Idusuario { get; set; }
        public  string User { get; set; }
        public  string Contrasena { get; set; }
        public  string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Permisos { get; set; }


        public Usuario(int idusuario, string user, string contrasena, string nombre, string apellido, string email, string telefono, int permisos)
        {
            Idusuario = idusuario;
            User = user;
            Contrasena = contrasena;    
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Permisos = permisos;
        }
    }
}
