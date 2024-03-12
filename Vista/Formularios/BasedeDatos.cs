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
        public BasedeDatos()
        {
            InitializeComponent();
        }

        private void Bkpbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea ser redirigido a la consola de administracion?","Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                contextoBKP.GenerarBKP();
            }else if (dialogResult == DialogResult.No)
            {
                return;
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
            DialogResult dialogResult = MessageBox.Show("¿Desea restaurar la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                contextoBKP.RestaurarBKP();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
