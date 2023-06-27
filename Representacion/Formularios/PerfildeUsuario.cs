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
using CapaSoporte.Caché;
using COMUN;
using Dominios;

namespace Representacion
{
    public partial class PerfildeUsuario : Form
    {
        public PerfildeUsuario()
        {
            InitializeComponent();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show(); 
            this.Hide();
        }
        private void PerfildeUsuario_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            InicializarControlContraseñaEdit();
        }
        private void CargarDatosUsuario()
        {
            TipoCuenta tipoCuenta = new TipoCuenta();
            usuariolbl.Text = CacheUsuario.Usuario;
            nombrelbl.Text = CacheUsuario.Nombre;
            apellidolbl.Text = CacheUsuario.Apellido;
            emailbl.Text = CacheUsuario.Email;
            tipocuentalbl.Text = tipoCuenta.Obtenercuenta();

            usuariotxt.Text = CacheUsuario.Usuario;
            nombretxt.Text = CacheUsuario.Nombre;
            apellidotxt.Text = CacheUsuario.Apellido;
            emailtxt.Text = CacheUsuario.Email;
            InicializarLinkLabel();
            contraseñaactual.Text = "";
        }

        private void InicializarControlContraseñaEdit()
        {
            contraseñatxt.Enabled = false;
            contraseñatxt.UseSystemPasswordChar = true;
            confirmarcontraseñatxt.Enabled = false;
            confirmarcontraseñatxt.UseSystemPasswordChar = true;

        }
        private void InicializarLinkLabel()
        {
            linkLabel1.Text = "Editar";
            contraseñatxt.Text = CacheUsuario.Contraseña;
            confirmarcontraseñatxt.Text = CacheUsuario.Contraseña;
            confirmarcontraseñatxt.Enabled = false;
            contraseñatxt.Enabled = false;
        }
        private void reset()
        {
            CargarDatosUsuario();
            InicializarControlContraseñaEdit();
        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Editar")
            {
                linkLabel1.Text = "Cancelar";
                contraseñatxt.Enabled = true;
                confirmarcontraseñatxt.Enabled = true;
                contraseñatxt.Text = "";
                confirmarcontraseñatxt.Text = "";
            }
            else if (linkLabel1.Text == "Cancelar")
            {
                linkLabel1.Text = "Editar";
                contraseñatxt.Text = CacheUsuario.Contraseña;
                confirmarcontraseñatxt.Text = CacheUsuario.Contraseña;
                InicializarControlContraseñaEdit();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            CargarDatosUsuario();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (usuariotxt.Text == "")
            {
                MessageBox.Show("Ingresa un Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nombretxt.Text == "")
                {
                    MessageBox.Show("Ingresa un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (apellidotxt.Text == "")
                    {
                        MessageBox.Show("Ingresa un Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (emailtxt.Text == "" || MetodosComunes.ValidacionEMAIL(e, emailtxt.Text) == false)
                        {
                            MessageBox.Show("Ingresa un Email valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MetodosComunes.ValidacionPASSWORD(contraseñatxt.Text) == false && contraseñatxt.Enabled == true)
                            {
                                MessageBox.Show("Ingrese una contraseña valida. \n Recuerda que esta debe constar de letras, numeros y debe tener de 6 a 15 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (contraseñatxt.Text == confirmarcontraseñatxt.Text)
                                {
                                    if (MetodosComunes.Encrypt.GetSHA256(contraseñaactual.Text) == CacheUsuario.Contraseña)
                                    {
                                        var ModeloUsuario = new ModeloUsuario(id: CacheUsuario.IDusuario,
                                            usuario: usuariotxt.Text,
                                            contraseña: MetodosComunes.Encrypt.GetSHA256(contraseñatxt.Text),
                                            nombre: nombretxt.Text,
                                            apellido: apellidotxt.Text,
                                            email: emailtxt.Text);

                                        var resultado = ModeloUsuario.editarperfil();
                                        MessageBox.Show(resultado);
                                        ModeloUsuario.ObtenerUsuarioCompleto(usuariotxt.Text);
                                        reset();
                                        panel1.Visible = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Contraseña actual incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void PerfildeUsuario_MouseDown(object sender, MouseEventArgs e)
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
