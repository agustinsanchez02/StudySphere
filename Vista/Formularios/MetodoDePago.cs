using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMUN;
using Vista.Formularios;

namespace Vista
{
    
    public partial class MetodoDePago : Form
    {
        Controladora.Precios precios = new Controladora.Precios();
        Controladora.ContextoUsuario usuario = new Controladora.ContextoUsuario();
        public MetodoDePago(string usuario)
        {
            this.Usuario = usuario;
            InitializeComponent();
        }
        string Usuario;
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void MetodoDePago_Load(object sender, EventArgs e)
        {
            Visa.Checked = false;
           
            American_Express.Checked = false;
            Mastercard.Checked = false;
            label2.Text = "Total: ARS 0";
            bunifuDropdown1.selectedIndex = 0;
        }

        private void Mastercard_OnChange(object sender, EventArgs e)
        {
            Visa.Checked = Mastercard.Checked = American_Express.Checked = false;
            ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;
        }

        private void American_Express_OnChange(object sender, EventArgs e)
        {
            Visa.Checked = Mastercard.Checked = American_Express.Checked = false;
            ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;
        }

        private void Visa_OnChange(object sender, EventArgs e)
        {
            Visa.Checked = Mastercard.Checked = American_Express.Checked = false;
            ((Bunifu.Framework.UI.BunifuCheckbox)sender).Checked = true;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            suscripciones suscripciones = new suscripciones(Usuario);
            suscripciones.Show();
        }

        public void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedIndex == 1)
            {
                label2.Text = "Total: ARS " + precios.obtenerPrecioM();
            }
            if (bunifuDropdown1.selectedIndex == 2)
            {
                label2.Text = "Total: ARS " + precios.ObtenerPrecioA();
            }
            if (bunifuDropdown1.selectedIndex == 0)
            {
                label2.Text = "Total: ARS 0";
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedIndex != 0)
            {
                if(Visa.Checked || Mastercard.Checked || American_Express.Checked)
                {
                    if(titular.Text != "")
                    {
                        if(año.Text != "")
                        {
                            if (mes.Text != "")
                            {
                                if (cvv.Text != "")
                                {
                                    if (numerotarjeta.Text != "")
                                    {
                                        if (MetodosComunes.ValidatarjetaCredito(numerotarjeta.Text) == true)
                                        {
                                            if (precios.obtenerPrecioM() == 500)
                                            {
                                                usuario.permisos(2, Usuario);
                                                MessageBox.Show("Bienvenido a la comunidad de Biblioteca Virtual. \n" + "Ahora podras disfrutar de todos los beneficios de ser un usuario plus.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Hide();
                                                iniciar_sesion iniciar_Sesion = new iniciar_sesion();
                                                iniciar_Sesion.Show();
                                            }
                                            else
                                            {
                                                if (precios.obtenerPrecioM() == 1000)
                                                {
                                                    usuario.permisos(3, Usuario);
                                                    this.Hide();
                                                    MessageBox.Show("Bienvenido a la comunidad de Biblioteca Virtual. \n" +"Ahora podras disfrutar de todos los beneficios de ser un usuario premium.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.Hide();
                                                    iniciar_sesion iniciar_Sesion = new iniciar_sesion();
                                                    iniciar_Sesion.Show();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Numero de tarjeta invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Indique su numero de tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                { 
                                    MessageBox.Show("Indique su codigo de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Indique el mes de vencimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Inidque el año de vencimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inidique el titular de la tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show ("Seleccione plan anual o mensual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void titular_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloLetras(e, titular.Text);
        }

        private void numerotarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloNumeros(e);
        }

        private void cvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloNumeros(e);
            if (cvv.Text.Length == 2 && e.KeyChar != (char)Keys.Back)
            {
                SendKeys.Send("{TAB}");
            }
            if (cvv.Text.Length == 3 && e.KeyChar != (char)Keys.Back)
            {
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloNumeros(e);
            if (mes.Text.Length == 1 && e.KeyChar != (char)Keys.Back)
            {
                SendKeys.Send("{TAB}");
            }
            if (mes.Text.Length == 2 && e.KeyChar != (char)Keys.Back)
            {
                SendKeys.Send("{BACKSPACE}");
            }

        }

        private void año_KeyPress(object sender, KeyPressEventArgs e)
        {

            MetodosComunes.KeyPressSoloNumeros(e);
            if (año.Text.Length == 3 && e.KeyChar != (char)Keys.Back)
            {
                SendKeys.Send("{TAB}");
            }
            if (año.Text.Length == 4 && e.KeyChar != (char)Keys.Back)
            {
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void mes_Enter(object sender, EventArgs e)
        {
            if (mes.Text == "MM")
            {
                mes.Text = "";
                mes.ForeColor = Color.White;
            }
        }

        private void mes_Leave(object sender, EventArgs e)
        {
            if (mes.Text == "")
            {
                mes.Text = "MM";
                mes.ForeColor = Color.Gray;
            }
        }

        private void año_Leave(object sender, EventArgs e)
        {
            if (año.Text == "")
            {
                año.Text = "AAAA";
                año.ForeColor = Color.Gray;
            }
        }

        private void año_Enter(object sender, EventArgs e)
        {
            if (año.Text == "AAAA")
            {
                año.Text = "";
                año.ForeColor = Color.White;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MetodoDePago_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
