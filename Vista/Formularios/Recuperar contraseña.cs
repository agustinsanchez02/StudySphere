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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMUN;

namespace Vista
{
    public partial class RecuperarContraseña : Form
    {
        Controladora.ContextoMail controladora = new Controladora.ContextoMail();
        Controladora.ContextoUsuario contexto = new Controladora.ContextoUsuario();

        public string Mail { get; }

        public RecuperarContraseña(string mail)
        {
            InitializeComponent();
            Mail = mail;
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MetodosComunes.ValidacionPASSWORD(contraseña1.Text) == false)
            {
                MessageBox.Show("Ingrese una contraseña valida. \n Recuerda que esta debe constar de letras, numeros y debe tener de 6 a 15 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (contraseña1.Text == Contraseña2.Text)
                {
                    string contrasena = MetodosComunes.Encrypt.GetSHA256(contraseña1.Text.Trim());

                    MessageBox.Show(contexto.cambiarcontraseña(contrasena, Mail));
                    iniciar_sesion iniciar_Sesion = new iniciar_sesion();
                    this.Hide();
                    iniciar_Sesion.Show();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void iniciarsesionbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciar_sesion sesion = new iniciar_sesion();
            sesion.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
