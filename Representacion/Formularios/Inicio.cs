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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();            
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cerrar la sesión?", "Precaución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            if(CacheUsuario.Privilegios ==  Convert.ToInt32(Privilegios.StudyBasic))
            {

            }
            if (CacheUsuario.Privilegios == Convert.ToInt32(Privilegios.StudyPlus))
            {

            }
            if (CacheUsuario.Privilegios == Convert.ToInt32(Privilegios.StudyPremium))
            {

            }
            if (CacheUsuario.Privilegios == Convert.ToInt32(Privilegios.Admin))
            {

            }
        }
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
            if (MessageBox.Show("Estas seguro que deseas salir de la aplicación?", "Precaución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CerrarSesionBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cerrar la sesión?", "Precaución",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
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
    }
}
