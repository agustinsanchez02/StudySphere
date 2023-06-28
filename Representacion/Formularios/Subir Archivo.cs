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
using CapaSoporte.Caché;
using System.Runtime.InteropServices.ComTypes;

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
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|Imágenes (*.jpeg, *.jpg, *.png)|*.jpeg;*.jpg;*.png|Documento PDF (*.PDF)|*.pdf|Documentos Word (*.doc, *.docx)|*.doc,*.docx)"; //Presentacion PowerPoint (*.ppt, *.pptx)|*.ppt;*.pptx|Document Excel (*.xls, *.xlsx)|*.xls;*.xlsx
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivotxt.Text = openFileDialog1.FileName;
                var extension = Path.GetExtension(openFileDialog1.FileName);
                if (extension == ".pdf")
                {

                    this.Width = 800;
                    this.Height = 1046;
                    axAcroPDF1.Show();
                    rtfData.Clear();
                    pictureBox1.Hide();
                    rtfData.Hide();
                    axAcroPDF1.src = openFileDialog1.FileName;
                }
                else
                {
                    if (extension == ".doc" || extension == ".docx")
                    {
                        using (OpenFileDialog ofd = new OpenFileDialog())
                        {
                            try
                            {
                                rtfData.Clear();
                                axAcroPDF1.Hide();
                                pictureBox1.Hide();
                                rtfData.Show();
                                this.Width = 800;
                                this.Height = 1046;
                                object readOnly = true;
                                object visible = true;
                                object save = false;
                                object filename = openFileDialog1.FileName;
                                object newTemplate = false;
                                object docType = 0;
                                object missing = Type.Missing;
                                Microsoft.Office.Interop.Word._Document document = null;
                                Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                                document = application.Documents.Open(ref filename, ref missing, readOnly, ref missing, ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                                document.ActiveWindow.Selection.WholeStory();
                                document.ActiveWindow.Selection.Copy();
                                System.Windows.Forms.IDataObject dataObject = Clipboard.GetDataObject();
                                rtfData.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                                application.Quit(ref missing, ref missing, ref missing);
                            }
                            catch
                            {
                                MessageBox.Show("No se pudo cargar el archivo");
                            }
                        }
                    }
                    else
                    {
                        if (extension == ".jpg" || extension == ".png" || extension == "jpeg")
                        {
                            rtfData.Clear();
                            axAcroPDF1.Hide();
                            rtfData.Hide();
                            pictureBox1.Show();
                            this.Width = 800;
                            this.Height = 1046;
                            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                        }
                        else 
                        {
                            MessageBox.Show("Formato incompatible.\nLos formatos compatibles son pdf, word e imagenes","Error");
                            archivotxt.Text = "";
                        }
                    }
                }
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
                   ModeloArchivos modeloArchivos = new ModeloArchivos();    
                    
                    
                    if (modeloArchivos.GuardarArchivo(nombretxt.Text.Trim(), Path.GetExtension(openFileDialog1.FileName), file, CacheUsuario.Usuario) == true)
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
            this.Hide();            
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

        private void Subir_Archivo_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 223;
            axAcroPDF1.Hide();
            rtfData.Hide();
            pictureBox1.Hide();
        }

        private void splitContainer1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
