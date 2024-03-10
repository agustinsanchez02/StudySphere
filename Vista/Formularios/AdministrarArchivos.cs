using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Vista
{
    public partial class AdministrarArchivos : Form
    {
        Controladora.ContextoArchivo contextoArchivo = new Controladora.ContextoArchivo();
        Archivo archivo = new Archivo();

        public AdministrarArchivos()
        {
            InitializeComponent();
        }

        private void AdministrarArchivos_Load(object sender, EventArgs e)
        {
            LlenarData();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LlenarData()
        {
            dgv.DataSource = contextoArchivo.ListarDocs();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Subir_Archivo subir_Archivo = new Subir_Archivo();
            this.Hide();
            subir_Archivo.ShowDialog();
            this.Show();
            LlenarData();
        }

        private void AdministrarArchivos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void VerArchivo_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                var lista = new List<Archivo>();
                lista = contextoArchivo.Filtrodocumentos(id);

                foreach (var item in lista)
                {
                    try
                    {
                        //crear carpeta completa
                        string direccion = AppDomain.CurrentDomain.BaseDirectory;
                        string carpeta = direccion + "/temp/";
                        string UbicacionCompleta = carpeta + item.Nombre + item.Extension;
                        if (!Directory.Exists(carpeta))
                        {
                            Directory.CreateDirectory(carpeta);
                        }
                        if (File.Exists(UbicacionCompleta))
                        {
                            File.Delete(UbicacionCompleta);
                        }
                        File.WriteAllBytes(UbicacionCompleta , item.Doc);
                        var psi = new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = UbicacionCompleta,
                            UseShellExecute = true
                        };
                        Process.Start(psi);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    
                }
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (contextoArchivo.BorrarArchivos(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString())) == true)
            {
                MessageBox.Show("Archivos eliminados correctamente");
                LlenarData();
            }
            else
            {
                MessageBox.Show("Error al eliminar los archivos");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdministrador administrador = new VistaAdministrador();
            administrador.Show();
        }

    }
}
