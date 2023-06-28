using CapaSoporte.Caché;
using Dominios;
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

namespace Representacion
{
    public partial class VistaAdministrador : Form
    {
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
            ModeloUsuario modeloUsuario = new ModeloUsuario();
            modeloUsuario.ObtenerUsuarioCompleto(CacheUsuario.Usuario);
            TipoCuenta tipoCuenta = new TipoCuenta();
            lblTipoCuenta.Text = tipoCuenta.Obtenercuenta();
            lblnombre.Text = CacheUsuario.Nombre + CacheUsuario.Apellido;
            lblmail.Text = CacheUsuario.Email;
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
            Application.Exit();
        }
    }
}
