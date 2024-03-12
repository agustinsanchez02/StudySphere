using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using COMUN;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using Vista.Formularios;
using Controladora;
using Azure.Core;
using System.Net;

namespace Vista
{
    public partial class iniciar_sesion : Form
    {
        ContextoAuditoria contextoAuditoria = new ContextoAuditoria();  
        ContextoUsuario ContextoUsuario = new ContextoUsuario();
        public iniciar_sesion()
        {
            InitializeComponent();
        }
        int bandera = 1;

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void msgError(string msg)
        {
            lblErrorMensaje.Text = "      " + msg;
            lblErrorMensaje.Visible = true;
            lblErrorMensaje.ForeColor = Color.White;
        }
        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "Contraseña")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Color.White;
                Contraseña.UseSystemPasswordChar = true;
            }
        }
        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "Contraseña";
                Contraseña.ForeColor = Color.Gray;
                Contraseña.UseSystemPasswordChar = false;
            }
        }
        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Usuario/Mail")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.White;
            }
        }
        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "Usuario/Mail";
                Usuario.ForeColor = Color.Gray;
            }
        }
        public void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            Contraseña.Text = "Contraseña";
            Contraseña.ForeColor = Color.Gray;
            Contraseña.UseSystemPasswordChar = false;
            Usuario.Text = "Usuario/Mail";
            Usuario.ForeColor = Color.Gray;
            lblErrorMensaje.Visible = false;
            this.Show();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniciar_sesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            iniciar_sesion_MouseDown((object)sender, e);
        }

        private void Ojo_Click(object sender, EventArgs e)
        {
            {
                if (bandera == 0)
                {
                    Ojo.BackgroundImage = Properties.Resources.Ojo_cerrado;
                    Contraseña.UseSystemPasswordChar = true;
                    bandera = 1;
                    Ojo.Height = 30;
                    Ojo.Width = 26;
                }
                else
                {
                    Ojo.BackgroundImage = Properties.Resources.Ojo_abierto;
                    bandera = 0;
                    Contraseña.UseSystemPasswordChar = false;
                    Ojo.Width = 25;
                    Ojo.Height = 25;

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CorreoRecuperoPass recuperoPass = new CorreoRecuperoPass();
            recuperoPass.Show();
            this.Hide();
        }

        private void Registrarsebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.Show();
        }

        private void IniciarSesionbtn_Click(object sender, EventArgs e)
        {
            if (Usuario.Text != "Usuario/Mail")
            {
                if (Contraseña.Text != "Contraseña")
                {
                    ContextoUsuario contextousuario = new ContextoUsuario();
                    var loginvalido = contextousuario.iniciosesion(Usuario.Text, Contraseña.Text);
                    if (loginvalido == "Agregado")
                    {
                        string externalip = new WebClient().DownloadString("http://icanhazip.com");
                        string detalle = "el usuaio "+Usuario.Text+" ha iniciado sesion a las "+ DateTime.Now.Hour + ":"+ DateTime.Now.Minute+":" + DateTime.Now.Second +" con la IP publica: "+ externalip;
                        contextoAuditoria.AuditorialogIn(contextousuario.ObtenerUsuarioActual().ToString(), contextousuario.ObtenerEmailActual().ToString(), detalle);
                        this.Hide();
                        Bienvenida bienvenida = new Bienvenida();
                        bienvenida.ShowDialog();
                        if (contextousuario.obtenerpermisos() == 0)
                        {
                            VistaAdministrador vistaAdministrador = new VistaAdministrador();
                            vistaAdministrador.Show();
                        }
                        else
                        {
                            Inicio inicio = new Inicio();
                            inicio.Show();
                            inicio.FormClosed += CerrarSesion;
                        }

                    }
                    else
                    {
                        msgError("El usuario o la contraseña son incorrectos. \n      Por favor intente otra vez.");
                        Contraseña.Text = "Contraseña";
                        Contraseña.ForeColor = Color.Gray;
                        Contraseña.UseSystemPasswordChar = false;
                        Contraseña.Focus();

                    }
                }
                else msgError("Por favor ingresa una contraseña.");
            }
            else
            {
                msgError("Por favor Ingresa un Usuario o Mail.");
            }
        }

        private void iniciar_sesion_Load(object sender, EventArgs e)
        {

        }
    }
}

