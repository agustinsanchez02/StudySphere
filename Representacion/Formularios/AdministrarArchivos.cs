using CapaSoporte.Caché;
using Dominios;

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
namespace Representacion
{
    public partial class AdministrarArchivos : Form
    {
        ModeloArchivos modeloArchivos = new ModeloArchivos();
        CacheArchivos cache = new CacheArchivos();
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
            dgv.DataSource = modeloArchivos.ListarDocs();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Subir_Archivo subir_Archivo = new Subir_Archivo();
            this.Hide();
            subir_Archivo.ShowDialog();
            this.Show();
            LlenarData();
        }

        private void Editar_Click(object sender, EventArgs e)
        {

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
                CacheArchivos cache = new CacheArchivos();
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                cache.Id = id;
                var lista = new List<CacheArchivos>();
                lista = cache.FiltroDocumentos();

                foreach(CacheArchivos item in lista)
                { 

                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + "/temp/";
                    string ubicacioncompleta = carpeta + item.Extension;

                    if (!Directory.Exists(carpeta))
                    {
                        Directory.CreateDirectory(carpeta);
                    }
                    if (File.Exists(ubicacioncompleta))
                    {
                        File.Delete(ubicacioncompleta);
                    }
                    File.WriteAllBytes(ubicacioncompleta, item.Doc);
                    Process.Start(ubicacioncompleta);
                }
                

            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                CacheArchivos cache = new CacheArchivos();
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                cache.Id = id;
                if (cache.BorrarArchivo() == true)
                {
                    MessageBox.Show("Se ha borrado el archivo exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al borrar archivo");
                }
                LlenarData();
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
