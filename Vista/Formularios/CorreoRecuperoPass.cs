using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMUN;
using System.Runtime.InteropServices;

namespace Vista
{
    public partial class CorreoRecuperoPass : Form
    {
        Controladora.ContextoUsuario contextoUsuario = new Controladora.ContextoUsuario();
        Controladora.ContextoMail contextomail = new Controladora.ContextoMail();
        public CorreoRecuperoPass()
        {
            InitializeComponent();
        }
        EventArgs v;
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            v = e;
            if (Correo.Text != "" && Correo.ForeColor != Color.Silver)
            {
                if (COMUN.MetodosComunes.ValidacionEMAIL(e, Correo.Text))
                {
                    pctLineDecoration(pctCorreo, 1);
                }
                else
                {
                    pctLineDecoration(pctCorreo, 3);
                }
            }
        }
        public void pctLineDecoration(PictureBox a, int caso)
        {
            //Esta función la uso para las lineas de color verde y gris, una decoración bastante moderna//
            //Caso 1 significa que el usuario entro al TextBox y Caso 2 Significa que el usuario salió del TextBox//
            switch (caso)
            {
                case 1:
                    a.BackColor = Color.FromArgb(65, 168, 95); ;
                    break;
                case 2:
                    a.BackColor = Color.DarkGray; ;
                    break;
                case 3:
                    a.BackColor = Color.Red;
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        private void Correo_Enter(object sender, EventArgs e)
        {
            if (Correo.Text == "Correo")
            {
                Correo.Text = "";
                Correo.ForeColor = Color.White;
            }
        }

        private void Correo_Leave(object sender, EventArgs e)
        {
            if (Correo.Text == "")
            {
                Correo.Text = "Correo";
                Correo.ForeColor = Color.Gray;
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            iniciar_sesion sesion = new iniciar_sesion();
            sesion.Show();
            this.Close();
        }
        private void msgError(string msg)
        {
            lblErrorMensaje.Text = "      " + msg;
            lblErrorMensaje.Visible = true;
            lblErrorMensaje.ForeColor = Color.White;
        }
        private void CorreoRecuperoPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CorreoRecuperoPass_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Correo.Text == "" || MetodosComunes.ValidacionEMAIL(v, Correo.Text) == false)
            {
                msgError("Ingrese un correo valido.");
            }
            else
            {
                var correovalido = contextoUsuario.ObtenerUsuario(Correo.Text);
                if (correovalido == true)
                {
                    string mail = Correo.Text;
                    Random r = new Random();
                    int codigoVER = r.Next(10000, 99999);
                    CodigoConfirmacion formConfirmacion = new CodigoConfirmacion(codigoVER, mail);
                    try
                    {
                        SmtpClient cliente = contextomail.SmtpClient();

                        MailMessage correo = contextomail.MailVerificar(mail, codigoVER);

                        cliente.Send(correo);

                        string mensaje = string.Empty;

                    }
                    catch (Exception ex)
                    {
                        DialogResult dialog = MessageBox.Show(ex.Message, "Se produjo un error al enviar el código de verificación, por favor revisar si escribio bien su correo electronico.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    formConfirmacion.ShowDialog();
                    if (formConfirmacion.Confirmacion())
                    {
                        RecuperarContraseña form1 = new RecuperarContraseña(mail);
                        form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    msgError("El Correo no está registrado.\n      intente nuevamente.");
                    Correo.Text = "";
                    Correo.ForeColor = Color.White;
                    Correo.Focus();
                }

            }
        }
    }
}
