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
using Dominios;
using System.Runtime.InteropServices;

namespace Representacion
{
    public partial class Subir_Archivo : Form
    {

        static string cadena = "Data Source = DESKTOP-J6FH9OJ\\SQLEXPRESS; Initial Catalog = Studysphere; Integrated Security = True";
        public Subir_Archivo()
        {
            InitializeComponent();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
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
                   ModeloUsuario modeloUsuario = new ModeloUsuario();
                    if (modeloUsuario.GuardarArchivo(nombretxt.Text.Trim(), Path.GetExtension(openFileDialog1.FileName), file) == true)
                    {
                        MessageBox.Show("Archivo subido con exito.");
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido subir el archivo.");
                    }
                }
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Subir_Archivo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
