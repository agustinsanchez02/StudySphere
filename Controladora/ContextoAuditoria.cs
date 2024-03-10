using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Controladora
{
    public class ContextoAuditoria
    {
        Auditoria auditoria = new Auditoria();

        public void AuditorialogIn(string usuario, string mail, string descripcion)
        {
            auditoria.AuditorialogIn(usuario, mail, descripcion);
        }
        public void AuditoriaLogOut(string usuario, string mail, string descripcion)
        {
            auditoria.AuditoriaLogOut(usuario, mail, descripcion);
        }
        public void AuditoriaAltaArchivo(string modulo, string usuario, string descripcion, string nombre, string extension, int tamaño, DateTime fechacreacion, string Materia, string Carrera)
        {
            auditoria.AuditoriaAltaArchivo(modulo, usuario, descripcion, nombre, extension, tamaño, fechacreacion, Materia, Carrera);
        }
        public void AuditoriaBajaArchivo(string modulo, string usuario, string descripcion, string nombre, string extension, int tamaño, DateTime fechacreacion, string Materia, string Carrera)
        {
            auditoria.AuditoriaBajaArchivo(modulo, usuario, descripcion, nombre, extension, tamaño, fechacreacion, Materia, Carrera);
        }
    }
}
