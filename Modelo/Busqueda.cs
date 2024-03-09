using System;
using System.Collections.Generic;

namespace MODELO.Entidades
{
    public partial class Busqueda
    {
        public static int Idbusqueda { get; set; }
        public static DateTime Fecha { get; set; }
        public static string Terminos { get; set; }
        public static int ResultadosObtenidos { get; set; }

        public Busqueda(int idbusqueda, DateTime fecha, string terminos, int resultadosObtenidos)
        {
            Idbusqueda = idbusqueda;
            Fecha = fecha;
            Terminos = terminos;
            ResultadosObtenidos = resultadosObtenidos;
        }

        public Busqueda()
        {
        }
    }
}
