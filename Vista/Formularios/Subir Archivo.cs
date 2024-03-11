using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMUN;
using Vista.Properties;
using Controladora;
using System.IO;

namespace Vista
{
    public partial class Subir_Archivo : Form
    {
        ContextoArchivo contextoArchivo = new ContextoArchivo();
        ContextoUsuario contextoUsuario = new ContextoUsuario();
        ContextoAuditoria contextoAuditoria = new ContextoAuditoria();
        ContextoCarrera contextoCarrera = new ContextoCarrera();
        ContextoMateria contextoMateria = new ContextoMateria();
        public Subir_Archivo()
        {
            InitializeComponent();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Explorar_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|Imágenes (*.jpeg, *.jpg, *.png)|*.jpeg;*.jpg;*.png|Documento PDF (*.PDF)|*.pdf|Documentos Word (*.doc, *.docx)|*.doc,*.docx|PowerPoint (*.ppt, *.pptx)|*.ppt, *.pptx|Document Excel (*.xls, *.xlsx)|*.xls;*.xlsx)";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivotxt.Text = openFileDialog1.FileName;
                var extension = Path.GetExtension(openFileDialog1.FileName);
                if (extension == ".pdf")
                {
                    this.Width = 933;
                    this.Height = 273;
                    axAcroPDF1.Hide();
                    rtfData.Hide();
                    pictureBox1.Hide();
                    //.NET no cuenta con lector de PDF
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
                                this.Width = 933;
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
                            this.Width = 933;
                            this.Height = 1046;
                            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                        }
                        else
                        {
                            if (extension == ".ppt" || extension == ".pptx")
                            {
                                this.Width = 933;
                                this.Height = 273;
                                axAcroPDF1.Hide();
                                rtfData.Hide();
                                pictureBox1.Hide();
                            }
                            else
                            {
                                if (extension == ".xls" || extension == ".xlsx")
                                {
                                    this.Width = 933;
                                    this.Height = 273;
                                    axAcroPDF1.Hide();
                                    rtfData.Hide();
                                    pictureBox1.Hide();
                                }else
                                {
                                    MessageBox.Show("Formato incompatible.\nLos formatos compatibles son pdf, word e imagenes", "Error");
                                    archivotxt.Text = "";
                                }
                            }
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
                if(Materiacb.Text == "" || CarreraCB.Text == "")
                {
                    MessageBox.Show("Ingrese una materia y carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        try
                        {
                            byte[] file = null;
                            Stream mystream = openFileDialog1.OpenFile();
                            MemoryStream obj = new MemoryStream();
                            mystream.CopyTo(obj);
                            file = obj.ToArray();
                            FileInfo fi = new FileInfo(openFileDialog1.FileName);
                            if (contextoArchivo.GuardarArchivo(nombretxt.Text.Trim(), Convert.ToInt32(fi.Length),Path.GetExtension(openFileDialog1.FileName), file, contextoUsuario.obtenerIDActual(), Materiacb.Text, CarreraCB.Text) == true)
                            {
                                string Descripcion = "El usuario "+ contextoUsuario.ObtenerUsuarioActual()+" ha subido un archivo llamado "+ nombretxt.Text+" con extension " + Path.GetExtension(openFileDialog1.FileName) +", a la materia "+ Materiacb.Text+" de la carrera "+ CarreraCB.Text+" a las " +DateTime.Now.Hour+ ":" + DateTime.Now.Minute +":"+DateTime.Now.Second;
                                contextoAuditoria.AuditoriaAltaArchivo("Archivos", contextoUsuario.ObtenerUsuarioActual(), Descripcion, nombretxt.Text.Trim(), Path.GetExtension(openFileDialog1.FileName), Convert.ToInt32(fi.Length), DateTime.Now, Materiacb.Text, CarreraCB.Text);
                                MessageBox.Show("Archivo subido con exito.");
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido subir el archivo.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }

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
            this.Height = 237;
            axAcroPDF1.Hide();
            rtfData.Hide();
            pictureBox1.Hide();
            CarreraCB.DataSource = contextoCarrera.ListarCarreras();
            CarreraCB.DisplayMember = "Nombre";
            Materiacb.DataSource = contextoMateria.ListarMaterias();
            Materiacb.DisplayMember = "Nombre";
        }

        private void splitContainer1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void archivotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
