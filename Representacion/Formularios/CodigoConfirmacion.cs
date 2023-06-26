using COMUN;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Representacion
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

        //DRAG MOVE, Mover formulario con panel// //Código Descarte, por la dudas se guarda para futuras actualizaciones//
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]

        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //Fin del código mover (drag)//


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
    }
}
