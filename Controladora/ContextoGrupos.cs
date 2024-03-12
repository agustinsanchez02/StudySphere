using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MODELO;

namespace Controladora
{
    public class ContextoGrupos
    {
        Acceso_a_Datos.Grupos grupos = new Acceso_a_Datos.Grupos();
        CacheGrupos cacheGrupos = new CacheGrupos();
        public void ObtenerGrupos(int id)
        {
            grupos.ObtenerPermisos(id);
        }
        public bool obtenerUsuarios()
        {
            return grupos.obtenerUsuarios();
        } 
        public bool obtenerArchivos()
        {
            return grupos.obtenerArchivos();
        }
        public bool obtenerMaterias()
        {
            return grupos.obtenerMaterias();
        }
        public bool obtenerCarreras()
        {
            return grupos.obtenerCarreras();
        }
        public bool obtenerBaseDatos()
        {
            return grupos.obtenerBaseDatos();
        }
        public bool obtenerReportesAuditoria()
        {
            return grupos.obtenerReportesAuditoria();
        }
        public bool obtenerReportesArchivos()
        {
            return grupos.obtenerReportesArchivos();
        }
        public bool obtenerGrupo()
        {
            return grupos.obtenerGrupo();
        }
        public DataTable ObtenerAdmins()
        {
           return grupos.ObtenerAdmins();
        }
        public string ModificarGrupo(int id, int usuarios, int archivos, int materias, int carreras, int baseDatos, int reportesAuditoria, int reportesArchivos, int grupo)
        {
            return grupos.ModificarGrupo(id, usuarios, archivos, materias, carreras, baseDatos, reportesAuditoria, reportesArchivos, grupo);
        }

    }
}
