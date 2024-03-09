using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
namespace Vista.Formularios
{
    public partial class BasedeDatos : Form
    {
        ContextoBKP contextoBKP = new ContextoBKP();
        string path;
        public BasedeDatos()
        {
            InitializeComponent();
        }

        private void Bkpbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(contextoBKP.GenerarBKP());
        }

        private void Explorar_Click(object sender, EventArgs e)
        {
            //obtener path
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\Backup";
            openFileDialog1.Filter = "Archivos de BKP (*.bak)|*.bak";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Rutatxt.Text = openFileDialog1.FileName;
            }
        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdministrador vistaAdministrador = new VistaAdministrador();
            vistaAdministrador.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Rutatxt.Text == "")
            {
                MessageBox.Show("Seleccione un BackUp");
                return;
            }
            if (MessageBox.Show("¿Desea restaurar la base de datos?", "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                MessageBox.Show(contextoBKP.RestaurarBKP(Rutatxt.Text));
                this.Hide();
                VistaAdministrador vistaAdministrador = new VistaAdministrador();
                vistaAdministrador.Show();
            }
        }
    }
}
