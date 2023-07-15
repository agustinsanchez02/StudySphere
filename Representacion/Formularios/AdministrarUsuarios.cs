using CapaSoporte.Caché;
using COMUN;
using Microsoft.Office.Interop.Word;
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
    public partial class AdministrarUsuarios : Form
    {
        public AdministrarUsuarios()
        {
            InitializeComponent();
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            CacheEditarUsuario cacheEditarUsuario = new CacheEditarUsuario();
            this.Width = 830;
            this.Height = 450;
            dgv.DataSource = cacheEditarUsuario.ListarUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text == "")
            {
                MessageBox.Show("El campo Nombre esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(apellidotxt.Text == "")
                {
                    MessageBox.Show("El campo Apellido esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if(usuariotxt.Text == "")
                    {
                        MessageBox.Show("El campo Usuario esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(emailtxt.Text == "" || MetodosComunes.ValidacionEMAIL(e, emailtxt.Text) == false)
                        {
                            MessageBox.Show("El campo Email esta vacio o es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var CacheEditarUsuario = new CacheEditarUsuario(id: CacheUsuario.IDusuario,
                                           usuario: usuariotxt.Text,
                                           nombre: nombretxt.Text,
                                           apellido: apellidotxt.Text,
                                           email: emailtxt.Text);

                            var resultado = CacheEditarUsuario.editarPerfil(Id: CacheEditarUsuario.IDusuario, Usuario: usuariotxt.Text, Nombre: nombretxt.Text, Apellido: apellidotxt.Text,Email: emailtxt.Text);
                            MessageBox.Show(resultado);
                            CacheEditarUsuario.ObtenetUsuarioCompleto(usuariotxt.Text);
                            CargarDatosUsuario();
                            this.Width = 830;
                        }
                    }
                }
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            this.Width = 1174;
            this.Height = 450;
            CargarDatosUsuario();
        }
        private void CargarDatosUsuario()
        {

                    
                    /*apellidotxt.Text = dgv.SelectedRows[3].ToString();
                    usuariotxt.Text = dgv.SelectedRows[1].ToString();
                    emailtxt.Text = dgv.SelectedRows[4].ToString();  */         
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosUsuario();
        }
    }
}
