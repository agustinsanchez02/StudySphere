using CapaSoporte.Caché;
using Dominios;
using Representacion.Formularios;
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
    public partial class suscripciones : Form
    {
        public suscripciones()
        {
            InitializeComponent();
        }
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
            ModeloUsuario modelo = new ModeloUsuario();
            modelo.privilegios(1, CacheUsuario.Usuario);
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.ShowDialog();
            Inicio inicio = new Inicio();
            inicio.Show();
            iniciar_sesion iniciar_Sesion = new iniciar_sesion();
            inicio.FormClosed += iniciar_Sesion.CerrarSesion;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            int precioM = 1000;
            int precioA = 10000;
            ModeloUsuario modelo = new ModeloUsuario();
            modelo.obtenerprecio(precioA, precioM);
            MetodoDePago pago = new MetodoDePago();
            pago.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            int precioM = 500;
            int precioA = 3500;
            ModeloUsuario modelo = new ModeloUsuario();
            modelo.obtenerprecio(precioA, precioM);
            MetodoDePago pago = new MetodoDePago();
            pago.Show();
        }

        private void suscripciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
