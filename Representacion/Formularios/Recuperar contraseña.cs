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
using FontAwesome.Sharp;

namespace Representacion
{
    public partial class Form1 : Form
    {
        public string Mail { get; }

        public Form1(string mail)
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
                    SqlConnection conn = new SqlConnection("Data Source = DESKTOP-J6FH9OJ\\SQLEXPRESS; Initial Catalog = Studysphere; Integrated Security = True");

                    string contrasena = MetodosComunes.Encrypt.GetSHA256(contraseña1.Text.Trim());

                    iniciar_sesion iniciar_Sesion = new iniciar_sesion();


                    SqlCommand query = new SqlCommand("UPDATE Clientes SET Contraseña =  '" + contrasena + "' WHERE Email = '" + Mail + "'", conn);

                    conn.Open();
                    int r = query.ExecuteNonQuery();

                    if (r > 0)
                    {
                        MessageBox.Show("Contraseña cambiada con exito.");
                        Controladora.usuarios1 controladora = new Controladora.usuarios1();
                        SmtpClient cliente = controladora.SmtpClient();
                        MailMessage correo = controladora.Mail_cambiopass(Mail);
                        cliente.Send(correo);
                        string mensaje = string.Empty;

                        this.Hide();
                        iniciar_sesion sesion = new iniciar_sesion();
                        sesion.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido Cambiar la contraseña.");
                    }

                    conn.Close();
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
