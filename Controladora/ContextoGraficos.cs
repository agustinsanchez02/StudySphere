using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace Controladora
{
    public class ContextoGraficos
    {
        Acceso_a_Datos.Graficos graficos = new Acceso_a_Datos.Graficos();
        public ArrayList GraficoMateria()
        {
            return graficos.GraficoMateria();
        }
        public ArrayList GraficoCantidad()
        {
            return graficos.GraficoCantidad();
        }
        public ArrayList GraficoCarrera()
        {
            return graficos.GraficoCarrera();
        }
        public ArrayList GraficoCantidadCarrera()
        {
            return graficos.GraficoCantidadCarrera();
        }
        public DataTable GraficoMovimientoArchivo()
        {
            return graficos.GraficoMovimientoArchivo();
        }
   
        public DataTable GraficoMovimientoUsuarioLogIn()
        {
            return graficos.GraficoMovimientoUsuarioLogIn();
        }
        public ArrayList GraficoExtension()
        {
            return graficos.GraficoExtension();
        }
        public ArrayList GraficoCantidadExtension()
        {
            return graficos.GraficoCantidadExtension();
        }
    }
}
