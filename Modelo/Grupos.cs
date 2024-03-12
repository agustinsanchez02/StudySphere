using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Grupos
    {
        public int IdGrupo { get; set; }
        public bool Usuarios { get; set; }
        public bool Archivos { get; set; }
        public bool Materias { get; set; }
        public bool Carreras { get; set; }
        public bool BaseDatos { get; set; }
        public bool reportesAuditoria { get; set; }
        public bool ReportesArchivos { get; set; }
        public bool Grupo { get; set; }
        public int IdUsuario { get; set; }
    }
}
