using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using COMUN;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Web;
using System.Windows.Media;

namespace Representacion
{
    public partial class Subir_Archivo : Form
    {

        static string cadena = "Data Source = DESKTOP-J6FH9OJ\\SQLEXPRESS; Initial Catalog = Studysphere; Integrated Security = True";
        public Subir_Archivo()
        {
            InitializeComponent();
        }
        
        private void Explorar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivotxt.Text = openFileDialog1.FileName;
                axAcroPDF1.src = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (archivotxt.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ingrese un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    byte[] file = null;
                    Stream mystream = openFileDialog1.OpenFile();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        mystream.CopyTo(ms); 
                        file = ms.ToArray();

                    }
                    using (SqlConnection oconexion = new SqlConnection(cadena))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Archivos (Nombre,Extension, doc) VALUES (@nombre, @extension,@doc)", oconexion);
                        cmd.Parameters.AddWithValue("@nombre", nombretxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@extension", Path.GetExtension(openFileDialog1.FileName));
                        cmd.Parameters.AddWithValue("@doc", file);
                        cmd.CommandType = CommandType.Text;

                        oconexion.Open();
                        int r = cmd.ExecuteNonQuery();

                        if (r > 0)
                        {
                            MessageBox.Show("Archivo subido con exito.");
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido Cambiar la contraseña.");
                        }
                        oconexion.Close();
                    }
                }
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
