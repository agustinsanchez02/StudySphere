using Acceso_a_Datos;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vista
{
    public partial class Inicio : Form
    {
        Controladora.ContextoUsuario ContextoUsuarios = new Controladora.ContextoUsuario();
        Controladora.TipoCuenta tipoCuenta = new Controladora.TipoCuenta();
        Controladora.ContextoArchivo contextoArchivo = new Controladora.ContextoArchivo();
        Controladora.ContextoAuditoria contextoAuditoria = new Controladora.ContextoAuditoria();
        int visualizar = 0;

        public Inicio()
        {
            InitializeComponent();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
       
        private void Inicio_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            dataGridView1.DataSource = contextoArchivo.ListarDocs();
        }
        public void CargarDatosUsuario()
        {
            ContextoUsuarios.ObtenerUsuarioCompleto(ContextoUsuarios.ObtenerUsuarioActual());
            lblTipoCuenta.Text = tipoCuenta.ObtenerTipoCuenta();
            lblnombre.Text = ContextoUsuarios.ObtenerNombreActual() + " " + ContextoUsuarios.ObtenerApellidoActual();
            lblmail.Text = ContextoUsuarios.ObtenerEmailActual();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir de la aplicación?", "Precaución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string descripcion = "El usuario " + ContextoUsuarios.ObtenerUsuarioActual() + " ha cerrado sesión forzadamente a las " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                contextoAuditoria.AuditoriaLogOut(ContextoUsuarios.ObtenerUsuarioActual().ToString(), ContextoUsuarios.ObtenerEmailActual().ToString(), descripcion);
                Application.Exit();
            }
        }

        private void Buscartxt_Leave(object sender, EventArgs e)
        {
            if (Buscartxt.Text == "")
            {
                Buscartxt.Text = "Buscar libros o materias";
                Buscartxt.ForeColor = Color.FromArgb(158, 169, 181);
            }
        }

        private void Buscartxt_Enter(object sender, EventArgs e)
        {
            if (Buscartxt.Text == "Buscar libros o materias")
            {
                Buscartxt.Text = "";
                Buscartxt.ForeColor = Color.White;
            }
        }

        private void CerrarSesionBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cerrar la sesión?", "Precaución",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string descripcion = "El usuario " + ContextoUsuarios.ObtenerUsuarioActual() + " ha cerrado sesión a las " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second ;
                contextoAuditoria.AuditoriaLogOut(ContextoUsuarios.ObtenerUsuarioActual().ToString(), ContextoUsuarios.ObtenerEmailActual().ToString(), descripcion);
                iniciar_sesion iniciar_Sesion = new iniciar_sesion();
                this.Hide();
                iniciar_Sesion.Show();
            }
        }

        private void SubirArchivoBTN_Click(object sender, EventArgs e)
        {
            Subir_Archivo subir = new Subir_Archivo();
            this.Hide();
            subir.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PerfildeUsuario perfildeUsuario = new PerfildeUsuario();
            perfildeUsuario.Show();
            this.Hide();
        }

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void verArchivobtn_Click(object sender, EventArgs e)
        {
            if (visualizar == 3 && ContextoUsuarios.obtenerpermisos() == Convert.ToInt32(Controladora.Permisos.StudyBasic))
            {
                DialogResult result = MessageBox.Show("Si quieres visualizar este archivo deberas contratar un plan superior. ¿Deseas contratar otro plan?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    suscripciones suscripciones = new suscripciones(ContextoUsuarios.ObtenerUsuarioActual());
                    suscripciones.Show();
                    this.Hide();
                }

            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
                            File.WriteAllBytes(UbicacionCompleta, item.Doc);
                            var psi = new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = UbicacionCompleta,
                                UseShellExecute = true
                            };
                            visualizar = visualizar + 1;
                            Process.Start(psi);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }

                    }
                }
            }

        }

        private void Descargarbtn_Click(object sender, EventArgs e)
        {
            if (ContextoUsuarios.obtenerpermisos() == Convert.ToInt32(Controladora.Permisos.StudyBasic))
            {
                DialogResult result = MessageBox.Show("No tienes permisos para descargar archivos. Contrata un plan superior, ¿Deseas contratar un plan superior?", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    suscripciones suscripciones = new suscripciones(ContextoUsuarios.ObtenerUsuarioActual());
                    suscripciones.Show();
                    this.Hide();
                }

            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var lista = new List<Archivo>();
                lista = contextoArchivo.Filtrodocumentos(id);
                foreach (var item in lista)
                {
                    try
                    {
                        SaveFileDialog dialog = new SaveFileDialog();
                        dialog.Filter = "All files |*.*";
                        dialog.FileName = item.Nombre;
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(dialog.FileName + item.Extension, item.Doc);
                            MessageBox.Show("Archivo descargado exitosamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            if(Buscartxt.Text == "Buscar libros o materias")
            {
                dataGridView1.DataSource = contextoArchivo.ListarDocs();
            }else
            {
                dataGridView1.DataSource = contextoArchivo.FiltroArchivo(Buscartxt.Text);
            }
        }
    }
}
