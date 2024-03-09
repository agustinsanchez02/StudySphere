using COMUN;
using Controladora;
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

namespace Vista
{
    public partial class AdministrarUsuarios : Form
    {
        Controladora.ContextoUsuario ContextoUsuarios = new Controladora.ContextoUsuario();

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

            this.Width = 987;
            this.Height = 519;
            dgv.DataSource = ContextoUsuarios.ListarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text == "")
            {
                MessageBox.Show("El campo Nombre esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (apellidotxt.Text == "")
                {
                    MessageBox.Show("El campo Apellido esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (usuariotxt.Text == "")
                    {
                        MessageBox.Show("El campo Usuario esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (emailtxt.Text == "" || MetodosComunes.ValidacionEMAIL(e, emailtxt.Text) == false)
                        {
                            MessageBox.Show("El campo Email esta vacio o es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var ContextoUsuario = new ContextoUsuario(id: ContextoUsuarios.obtenerIDActual(),
                                           usuario: usuariotxt.Text,
                                           nombre: nombretxt.Text,
                                           apellido: apellidotxt.Text,
                                           email: emailtxt.Text);

                            var resultado = ContextoUsuarios.editarperfil(Id: ContextoUsuarios.obtenerIDActual(), Usuario: usuariotxt.Text, Nombre: nombretxt.Text, Apellido: apellidotxt.Text, Email: emailtxt.Text, telefono: telefonotxt.Text, Contraseña: contraseñatxt.Text, Convert.ToInt32(permisostxt.Text));
                            MessageBox.Show(resultado);
                            ContextoUsuario.ObtenerUsuarioCompleto(usuariotxt.Text);
                            this.Width = 987;
                            AdministrarUsuarios_Load(sender, e);
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
            this.Width = 1371;
            this.Height = 628;
            CargarDatosUsuario();
        }
        private void CargarDatosUsuario()
        {
            if (dgv.SelectedRows.Count == 1)
            {
                usuariotxt.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                nombretxt.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                apellidotxt.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                emailtxt.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                telefonotxt.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                permisostxt.Text = dgv.CurrentRow.Cells[6].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }


        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosUsuario();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (ContextoUsuarios.EliminarUsuario(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)) == true)
            {
                MessageBox.Show("Usuario eliminado");
                AdministrarUsuarios_Load(sender, e);
            }
            else
            {
                Console.WriteLine("Usuario no eliminado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdministrador vistaAdministrador = new VistaAdministrador();
            vistaAdministrador.Show();
        }
    }
}
