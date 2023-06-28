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
using Dominios;
using FontAwesome.Sharp;

namespace Representacion
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        int bandera = 0;

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciar_sesion sesion = new iniciar_sesion();
            sesion.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(nombretxt.Text == "")
            {
                MessageBox.Show("Ingrese su nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if( apellidotxt.Text == "")
                {
                    MessageBox.Show("Ingrese su apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(usuariotxt.Text == "")
                    {
                        MessageBox.Show("Ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MetodosComunes.ValidacionEMAIL(e, emailtxt.Text) == false)
                        {
                            MessageBox.Show("Ingrese un correo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MetodosComunes.ValidacionPASSWORD(contrasenatxt.Text) == false)
                            {
                                MessageBox.Show("Ingrese una contraseña valida. \n Recuerda que esta debe constar de letras, numeros y debe tener de 6 a 15 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                SqlConnection conn = new SqlConnection("Data Source = DESKTOP-J6FH9OJ\\SQLEXPRESS; Initial Catalog = Studysphere; Integrated Security = True");



                                string nombre = nombretxt.Text;
                                string apellido = apellidotxt.Text;
                                string usuario = usuariotxt.Text;
                                string contrasena = MetodosComunes.Encrypt.GetSHA256(contrasenatxt.Text.Trim());
                                string email = emailtxt.Text;

                                SqlCommand query = new SqlCommand("INSERT INTO clientes VALUES('" + usuario + "', '" + contrasena + "', '" + nombre + "', '" + apellido + "', '" + email +"', 1)", conn);

                                conn.Open();
                                int r = query.ExecuteNonQuery();

                                if (r > 0)
                                {
                                    MessageBox.Show("Usuario registrado con exito.");
                                    Controladora.usuarios1 controladora = new Controladora.usuarios1();
                                    SmtpClient cliente = controladora.SmtpClient();
                                    MailMessage correo = controladora.Mail_Registro(email, nombre, apellido, usuario);
                                    cliente.Send(correo);
                                    string mensaje = string.Empty;

                                    this.Hide();
                                    suscripciones subs = new suscripciones();
                                    ModeloUsuario modeloUsuario = new ModeloUsuario();
                                    modeloUsuario.iniciosesion(usuariotxt.Text, contrasenatxt.Text);
                                    subs.Show();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido registrar el usuario.");
                                }

                                conn.Close();
                            }
                        }
                    }
                }
            }
         
        
        }

        private void nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloLetras(e, nombretxt.Text);
        }

        private void apellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloLetras(e, apellidotxt.Text);
        }



        private void Ojo_Click(object sender, EventArgs e)
        {
            {
                if (bandera == 1)
                {
                    Ojo.BackgroundImage = Properties.Resources.Ojo_cerrado;
                    contrasenatxt.UseSystemPasswordChar = true;
                    bandera = 0;
                    Ojo.Height = 30;
                    Ojo.Width = 26;
                }
                else
                {
                    Ojo.BackgroundImage = Properties.Resources.Ojoabierto;
                    bandera = 1;
                    contrasenatxt.UseSystemPasswordChar = false;
                    Ojo.Width= 25;
                    Ojo.Height= 25;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_MouseDown(object sender, MouseEventArgs e)
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
