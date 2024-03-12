using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Graficos : Form
    {
        Controladora.ContextoGraficos contextoGraficos = new Controladora.ContextoGraficos();
        public Graficos()
        {
            InitializeComponent();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {
            Visualizarcb.Items.Add("Materia");
            Visualizarcb.Items.Add("Carrera");
            Visualizarcb.Items.Add("Extension");
            Visualizarcb.SelectedItem = "Materia";
            Visualizarcb_SelectedIndexChanged(sender, e);
        }

        private void Visualizarcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Visualizarcb.Text == "Materia")
            {
                label2.Text = "Mostrando actualmente Materias favoritas";
                ChartMateriaPref.Series[0].Points.Clear();
                ChartMateriaPref.Series[1].Points.Clear();
                ChartMateriaPref.Series[0].Points.DataBindXY(contextoGraficos.GraficoMateria(), contextoGraficos.GraficoCantidad());
            }
            if(Visualizarcb.Text == "Carrera")
            {
                label2.Text = "Mostrando actualmente Carreras favoritas";
                ChartMateriaPref.Series[0].Points.Clear();
                ChartMateriaPref.Series[1].Points.Clear();
                ChartMateriaPref.Series[1].Points.DataBindXY(contextoGraficos.GraficoCarrera(), contextoGraficos.GraficoCantidadCarrera());
            }
            if (Visualizarcb.Text == "Extension")
            {
                label2.Text = "Mostrando actualmente Extensiones favoritas";
                ChartMateriaPref.Series[0].Points.Clear();
                ChartMateriaPref.Series[1].Points.Clear();
                ChartMateriaPref.Series[0].Points.DataBindXY(contextoGraficos.GraficoExtension(), contextoGraficos.GraficoCantidadExtension());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VistaAdministrador vistaAdministrador = new VistaAdministrador();
            vistaAdministrador.Show();
        }
    }
}
