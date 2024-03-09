using System;
using System.Collections.Generic;
using System.Data;


namespace MODELO.Entidades
{
    public partial class Archivo
    {
        public virtual int Idarchivo { get; set; }
        public string Nombre { get; set; }
        public int Tamaño { get; set; }

        public DateTime FechaCreacion { get; set; }
        public string Materia { get; set; }
        public string Carrera { get; set; }
        public int Idusuario { get; set; }

        public byte[] Doc { get; set; }
        public string Extension { get; set; }   
       
        public Archivo(int idarchivo, string nombre, int tamaño, DateTime fechaCreacion,
                      string materia, string carrera, int idusuario,
                      Byte[] doc,string extension)
        {
            Idarchivo = idarchivo;
            Nombre = nombre;
            Tamaño = tamaño;
            FechaCreacion = fechaCreacion;
            Materia = materia;
            Carrera = carrera;
            Idusuario = idusuario;
            Doc = doc;
            Extension = extension;
          
        }

        public Archivo()
        {
        }
        

    }
}
