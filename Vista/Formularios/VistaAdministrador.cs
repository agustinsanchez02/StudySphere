using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Formularios;

namespace Vista
{
    public partial class VistaAdministrador : Form
    {
        ContextoUsuario modeloUsuario = new ContextoUsuario();
        ContextoAuditoria contextoAuditoria = new ContextoAuditoria();
        ContextoUsuario ContextoUsuarios = new ContextoUsuario();
        public VistaAdministrador()
        {
            InitializeComponent();
        }

        private void VistaAdministrador_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void CargarDatosUsuario()
        {
            modeloUsuario.ObtenerUsuarioCompleto(modeloUsuario.ObtenerUsuarioActual());
            lblTipoCuenta.Text = modeloUsuario.ObtenerTipoCuenta();
            lblnombre.Text = modeloUsuario.ObtenerNombreActual() + modeloUsuario.ObtenerApellidoActual();
            lblmail.Text = modeloUsuario.ObtenerEmailActual();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarArchivos administrarArchivos = new AdministrarArchivos();
            administrarArchivos.Show();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarUsuarios administrarUsuarios = new AdministrarUsuarios();
            administrarUsuarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string descripcion = "El usuario " + ContextoUsuarios.ObtenerUsuarioActual() + " ha cerrado sesión a las " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            contextoAuditoria.AuditoriaLogOut(ContextoUsuarios.ObtenerUsuarioActual().ToString(), ContextoUsuarios.ObtenerEmailActual().ToString(), descripcion);
            Application.Exit();
        }

        private void bkpbtn_Click(object sender, EventArgs e)
        {
            BasedeDatos basedeDatos = new BasedeDatos();
            basedeDatos.Show();
            this.Hide();
        }
    }
}
