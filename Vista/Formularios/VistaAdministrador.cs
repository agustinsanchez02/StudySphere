using Controladora;
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
    public partial class VistaAdministrador : Form
    {
        ContextoUsuario modeloUsuario = new ContextoUsuario();
        ContextoAuditoria contextoAuditoria = new ContextoAuditoria();
        ContextoUsuario ContextoUsuarios = new ContextoUsuario();
        ContextoGrupos contextoGrupos = new ContextoGrupos();
        
        public VistaAdministrador()
        {
            InitializeComponent();
        }

        private void VistaAdministrador_Load(object sender, EventArgs e)
        {
            contextoGrupos.ObtenerGrupos(ContextoUsuarios.obtenerIDActual());
            CargarDatosUsuario();
            reportepnl.Visible = false;
            if (contextoGrupos.obtenerUsuarios() == true)
            {
                AdministrarUsuarios.Enabled = true;
            }else
            {
                AdministrarUsuarios.Enabled = false;
            }
            if (contextoGrupos.obtenerArchivos() == true)
            {
                AdministrarArchivos.Enabled = true;
            }
            else
            {
                AdministrarArchivos.Enabled = false;
            }
            if (contextoGrupos.obtenerMaterias() == true)
            {
                AdministrarMaterias.Enabled = true;
            }
            else
            {
                AdministrarMaterias.Enabled = false;
            }
            if (contextoGrupos.obtenerCarreras() == true)
            {
                AdministrarCarreras.Enabled = true;
            }
            else
            {
                AdministrarCarreras.Enabled = false;
            }
            if (contextoGrupos.obtenerBaseDatos() == true)
            {
                bkpbtn.Enabled = true;
            }
            else
            {
                bkpbtn.Enabled = false;
            }
            if (contextoGrupos.obtenerReportesAuditoria() == true)
            {
                auditoriapnlbtn.Enabled = true;
            }
            else
            {
                auditoriapnlbtn.Enabled = false;
            }
            if (contextoGrupos.obtenerReportesArchivos() == true)
            {
                Archivopnlbtn.Enabled = true;
            }
            else
            {
                Archivopnlbtn.Enabled = false;
            }
            if (contextoGrupos.obtenerGrupo() == true)
            {
                Permisosbtn.Enabled = true;
            }
            else
            {
                Permisosbtn.Enabled = false;
            }
            
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void CargarDatosUsuario()
        {
            modeloUsuario.ObtenerUsuarioCompleto(modeloUsuario.ObtenerUsuarioActual());
            lblTipoCuenta.Text = modeloUsuario.ObtenerTipoCuenta();
            lblnombre.Text = modeloUsuario.ObtenerNombreActual() + modeloUsuario.ObtenerApellidoActual();
            lblmail.Text = modeloUsuario.ObtenerEmailActual();
        }

        private void AdministrarArchivos_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarArchivos administrarArchivos = new AdministrarArchivos();
            administrarArchivos.Show();
        }

        private void AdministrarUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarUsuarios administrarUsuarios = new AdministrarUsuarios();
            administrarUsuarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string descripcion = "El usuario " + ContextoUsuarios.ObtenerUsuarioActual() + " ha cerrado sesión a las " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            contextoAuditoria.AuditoriaLogOut(ContextoUsuarios.ObtenerUsuarioActual().ToString(), ContextoUsuarios.ObtenerEmailActual().ToString(), descripcion);
            this.Close();
            iniciar_sesion iniciar_Sesion= new iniciar_sesion();
            iniciar_Sesion.Show();
        }

        private void bkpbtn_Click(object sender, EventArgs e)
        {
           BasedeDatos basedeDatos = new BasedeDatos();
            basedeDatos.Show();
            this.Hide();
        }

        private void AdministrarMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarMaterias administrarMaterias = new AdministrarMaterias();
            administrarMaterias.Show();
        }

        private void AdministrarCarreras_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarCarreras administrarCarreras = new AdministrarCarreras();
            administrarCarreras.Show();
        }

        private void Reportesbtn_Click(object sender, EventArgs e)
        {
            if (reportepnl.Visible == true)
                reportepnl.Visible = false;
            else
            {
                reportepnl.Visible = true;
            }
           
        }

        private void Archivopnlbtn_Click(object sender, EventArgs e)
        {
            Graficos graficos = new Graficos();
            graficos.Show();
            this.Hide();
        }

        private void auditoriapnlbtn_Click(object sender, EventArgs e)
        {
            GraficosAuditoria graficosAuditoria = new GraficosAuditoria();
            graficosAuditoria.Show();
            this.Hide();
        }

        private void Permisosbtn_Click(object sender, EventArgs e)
        {
            AdministrarGrupos administrarGrupos = new AdministrarGrupos();
            administrarGrupos.Show();
            this.Hide();
        }
    }
}
