using COMUN;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Vista
{
    public partial class CodigoConfirmacion : Form
    {
        public CodigoConfirmacion(int codigoazar, string mail)
        {
            InitializeComponent();
            CodigoAzar = codigoazar;
            Mail = mail;
        }
        int CodigoAzar;
        string Mail;
        bool confirmacion = false;

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloNumeros(e);
            //Aquí usamos los tabIndex como identificadores//
            TextBox a = new TextBox();
            a = sender as TextBox;
            identificadorText(a, e);

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            string codigo = txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text;
            if (codigo == CodigoAzar.ToString())
            {
                confirmacion = true;
                this.Close();
            }
            else
            {
                confirmacion = false;
            }

        }
        private void pnlLabel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void CodigoConfirmacion_Load(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            lblMail.Text = lblMail.Text + ": " + Mail;

        }



        public void identificadorText(TextBox a, KeyPressEventArgs e)
        {
            switch (a.TabIndex)
            {
                case 0:
                    if (char.IsNumber(e.KeyChar))
                    {
                        SendKeys.Send("{TAB}");
                    }
                    break;
                case 1:
                    if (char.IsNumber(e.KeyChar))
                    {
                        SendKeys.Send("{TAB}");
                    }
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
                case 2:
                    if (char.IsNumber(e.KeyChar))
                    {
                        SendKeys.Send("{TAB}");
                    }
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
                case 3:
                    if (char.IsNumber(e.KeyChar))
                    {
                        SendKeys.Send("{TAB}");
                    }
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
                case 4:
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
            }
        }



        private void ICOBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iniciarsesionbutton_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.Show();
        }

        public bool Confirmacion()
        {
            return confirmacion;
        }

        private void pnlLabel_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlLabel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
