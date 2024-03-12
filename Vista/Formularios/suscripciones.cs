
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
using Vista.Formularios;

namespace Vista
{
    public partial class suscripciones : Form
    {
        Controladora.ContextoUsuario usuario = new Controladora.ContextoUsuario();
        public suscripciones(string Usuario)
        {
            this.Usuario = Usuario;
            InitializeComponent();
        }
        string Usuario;
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuario.permisos(1, Usuario);
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.ShowDialog();
            iniciar_sesion iniciar_Sesion = new iniciar_sesion();
            iniciar_Sesion.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            int precioM = 1000;
            int precioA = 10000;
            usuario.obtenerprecio(precioA, precioM);
            MetodoDePago pago = new MetodoDePago(Usuario);
            pago.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            int precioM = 500;
            int precioA = 3500;
            usuario.obtenerprecio(precioA, precioM);
            MetodoDePago pago = new MetodoDePago(Usuario);
            pago.Show();
        }

        private void suscripciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
