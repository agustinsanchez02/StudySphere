using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Formularios
{
    public partial class GraficosAuditoria : Form
    {
        ContextoGraficos contextoGraficos = new ContextoGraficos();
        public GraficosAuditoria()
        {
            InitializeComponent();
        }

        private void GraficosAuditoria_Load(object sender, EventArgs e)
        {
            Visualizarcb.Items.Add("Auditoria de Archivos");
            Visualizarcb.Items.Add("Auditoria de LogIn");
        }

        private void Visualizarcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Visualizarcb.Text == "Auditoria de Archivos")
            {
                ChartArchivos.Visible = true;
                ChartLogIn.Visible = false;
                label2.Text = "Mostrando actualmente Auditoria de Archivos";
                ChartArchivos.Series[0].Points.Clear();
                ChartArchivos.DataSource = contextoGraficos.GraficoMovimientoArchivo();
                ChartArchivos.Series[0].XValueMember = "Movimiento";
                ChartArchivos.Series[0].YValueMembers = "Cantidad";

            }
            else
            {
                ChartLogIn.Visible = true;
                ChartArchivos.Visible = false;
                label2.Text = "Mostrando actualmente Auditoria de LogIn";
                ChartLogIn.Series[0].Points.Clear();
                ChartLogIn.DataSource = contextoGraficos.GraficoMovimientoUsuarioLogIn();
                ChartLogIn.Series[0].XValueMember = "Movimiento";
                ChartLogIn.Series[0].YValueMembers = "Cantidad";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VistaAdministrador vistaAdministrador = new VistaAdministrador();
            vistaAdministrador.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
