using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class CodigoConfirmacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLabel = new Panel();
            lblVerificar = new Label();
            panel1 = new Panel();
            lblInformacion = new Label();
            lblMail = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt4 = new TextBox();
            txt5 = new TextBox();
            txt3 = new TextBox();
            panel2 = new Panel();
            pnlLabel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLabel
            // 
            pnlLabel.BackColor = Color.FromArgb(30, 30, 30);
            pnlLabel.Controls.Add(lblVerificar);
            pnlLabel.Dock = DockStyle.Top;
            pnlLabel.ForeColor = Color.FromArgb(26, 28, 51);
            pnlLabel.Location = new Point(0, 0);
            pnlLabel.Margin = new Padding(4, 3, 4, 3);
            pnlLabel.Name = "pnlLabel";
            pnlLabel.Size = new Size(774, 69);
            pnlLabel.TabIndex = 0;
            pnlLabel.Paint += pnlLabel_Paint;
            pnlLabel.MouseDown += pnlLabel_MouseDown_1;
            // 
            // lblVerificar
            // 
            lblVerificar.AutoSize = true;
            lblVerificar.BackColor = Color.FromArgb(30, 30, 30);
            lblVerificar.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerificar.ForeColor = Color.White;
            lblVerificar.Location = new Point(195, 12);
            lblVerificar.Margin = new Padding(4, 0, 4, 0);
            lblVerificar.Name = "lblVerificar";
            lblVerificar.Size = new Size(356, 38);
            lblVerificar.TabIndex = 5;
            lblVerificar.Text = "Verificar su cuenta";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(lblInformacion);
            panel1.Controls.Add(lblMail);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 69);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 117);
            panel1.TabIndex = 6;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.BackColor = Color.FromArgb(30, 30, 30);
            lblInformacion.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformacion.ForeColor = Color.White;
            lblInformacion.Location = new Point(7, 3);
            lblInformacion.Margin = new Padding(4, 0, 4, 0);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(258, 23);
            lblInformacion.TabIndex = 6;
            lblInformacion.Text = "Información de tu cuenta";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Georgia", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.ForeColor = Color.White;
            lblMail.Location = new Point(7, 58);
            lblMail.Margin = new Padding(4, 0, 4, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(157, 21);
            lblMail.TabIndex = 6;
            lblMail.Text = "Correo electronico";
            // 
            // txt1
            // 
            txt1.BackColor = Color.FromArgb(227, 227, 227);
            txt1.Font = new Font("Consolas", 40F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(4, 1);
            txt1.Margin = new Padding(4, 3, 4, 3);
            txt1.MaxLength = 1;
            txt1.Name = "txt1";
            txt1.Size = new Size(144, 70);
            txt1.TabIndex = 0;
            txt1.Text = "1";
            txt1.TextAlign = HorizontalAlignment.Center;
            txt1.TextChanged += txt1_TextChanged;
            txt1.KeyPress += txt1_KeyPress;
            // 
            // txt2
            // 
            txt2.BackColor = Color.FromArgb(227, 227, 227);
            txt2.Font = new Font("Consolas", 40F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.Location = new Point(155, 1);
            txt2.Margin = new Padding(4, 3, 4, 3);
            txt2.MaxLength = 1;
            txt2.Name = "txt2";
            txt2.Size = new Size(144, 70);
            txt2.TabIndex = 1;
            txt2.Text = "1";
            txt2.TextAlign = HorizontalAlignment.Center;
            txt2.TextChanged += txt1_TextChanged;
            txt2.KeyPress += txt1_KeyPress;
            // 
            // txt4
            // 
            txt4.BackColor = Color.FromArgb(227, 227, 227);
            txt4.Font = new Font("Consolas", 40F, FontStyle.Regular, GraphicsUnit.Point);
            txt4.Location = new Point(458, 1);
            txt4.Margin = new Padding(4, 3, 4, 3);
            txt4.MaxLength = 1;
            txt4.Name = "txt4";
            txt4.Size = new Size(144, 70);
            txt4.TabIndex = 3;
            txt4.Text = "1";
            txt4.TextAlign = HorizontalAlignment.Center;
            txt4.TextChanged += txt1_TextChanged;
            txt4.KeyPress += txt1_KeyPress;
            // 
            // txt5
            // 
            txt5.BackColor = Color.FromArgb(227, 227, 227);
            txt5.Font = new Font("Consolas", 40F, FontStyle.Regular, GraphicsUnit.Point);
            txt5.Location = new Point(615, 1);
            txt5.Margin = new Padding(4, 3, 4, 3);
            txt5.MaxLength = 1;
            txt5.Name = "txt5";
            txt5.Size = new Size(144, 70);
            txt5.TabIndex = 4;
            txt5.Text = "1";
            txt5.TextAlign = HorizontalAlignment.Center;
            txt5.TextChanged += txt1_TextChanged;
            txt5.KeyPress += txt1_KeyPress;
            // 
            // txt3
            // 
            txt3.BackColor = Color.FromArgb(227, 227, 227);
            txt3.Font = new Font("Consolas", 40F, FontStyle.Regular, GraphicsUnit.Point);
            txt3.Location = new Point(307, 1);
            txt3.Margin = new Padding(4, 3, 4, 3);
            txt3.MaxLength = 1;
            txt3.Name = "txt3";
            txt3.Size = new Size(144, 70);
            txt3.TabIndex = 2;
            txt3.Text = "1";
            txt3.TextAlign = HorizontalAlignment.Center;
            txt3.TextChanged += txt1_TextChanged;
            txt3.KeyPress += txt1_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 30);
            panel2.Controls.Add(txt3);
            panel2.Controls.Add(txt5);
            panel2.Controls.Add(txt1);
            panel2.Controls.Add(txt2);
            panel2.Controls.Add(txt4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 192);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 85);
            panel2.TabIndex = 7;
            // 
            // CodigoConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(774, 277);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CodigoConfirmacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmación";
            Load += CodigoConfirmacion_Load;
            pnlLabel.ResumeLayout(false);
            pnlLabel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLabel;
        private Label lblVerificar;
        private Panel panel1;
        private Label lblInformacion;
        private Label lblMail;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt4;
        private TextBox txt5;
        private TextBox txt3;
        private Panel panel2;
    }
}