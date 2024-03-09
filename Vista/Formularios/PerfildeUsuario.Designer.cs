using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class PerfildeUsuario
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
            panel1 = new Panel();
            Cancelar = new Button();
            telefonotxt = new TextBox();
            emailtxt = new TextBox();
            Aceptar = new Button();
            contraseñaactual = new TextBox();
            usuariotxt = new TextBox();
            nombretxt = new TextBox();
            apellidotxt = new TextBox();
            contraseñatxt = new TextBox();
            confirmarcontraseñatxt = new TextBox();
            linkLabel1 = new LinkLabel();
            label12 = new Label();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            label15 = new Label();
            label9 = new Label();
            label10 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            usuariolbl = new Label();
            nombrelbl = new Label();
            apellidolbl = new Label();
            emailbl = new Label();
            tipocuentalbl = new Label();
            cerrarbtn = new Button();
            editarbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 10, 10);
            panel1.Controls.Add(Cancelar);
            panel1.Controls.Add(telefonotxt);
            panel1.Controls.Add(emailtxt);
            panel1.Controls.Add(Aceptar);
            panel1.Controls.Add(contraseñaactual);
            panel1.Controls.Add(usuariotxt);
            panel1.Controls.Add(nombretxt);
            panel1.Controls.Add(apellidotxt);
            panel1.Controls.Add(contraseñatxt);
            panel1.Controls.Add(confirmarcontraseñatxt);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(618, -2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 717);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.FromArgb(50, 50, 50);
            Cancelar.FlatStyle = FlatStyle.Popup;
            Cancelar.ForeColor = Color.White;
            Cancelar.Location = new Point(42, 642);
            Cancelar.Margin = new Padding(4, 3, 4, 3);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(120, 43);
            Cancelar.TabIndex = 9;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            Cancelar.Click += button3_Click;
            // 
            // telefonotxt
            // 
            telefonotxt.BackColor = Color.FromArgb(50, 50, 50);
            telefonotxt.BorderStyle = BorderStyle.FixedSingle;
            telefonotxt.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            telefonotxt.ForeColor = Color.White;
            telefonotxt.Location = new Point(42, 375);
            telefonotxt.Margin = new Padding(4, 3, 4, 3);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(329, 25);
            telefonotxt.TabIndex = 4;
            telefonotxt.UseSystemPasswordChar = true;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.FromArgb(50, 50, 50);
            emailtxt.BorderStyle = BorderStyle.FixedSingle;
            emailtxt.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.ForeColor = Color.White;
            emailtxt.Location = new Point(42, 309);
            emailtxt.Margin = new Padding(4, 3, 4, 3);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(329, 25);
            emailtxt.TabIndex = 4;
            emailtxt.UseSystemPasswordChar = true;
            // 
            // Aceptar
            // 
            Aceptar.BackColor = Color.FromArgb(50, 50, 50);
            Aceptar.FlatStyle = FlatStyle.Popup;
            Aceptar.ForeColor = Color.White;
            Aceptar.Location = new Point(253, 642);
            Aceptar.Margin = new Padding(4, 3, 4, 3);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(120, 43);
            Aceptar.TabIndex = 8;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = false;
            Aceptar.Click += button2_Click;
            // 
            // contraseñaactual
            // 
            contraseñaactual.BackColor = Color.FromArgb(50, 50, 50);
            contraseñaactual.BorderStyle = BorderStyle.FixedSingle;
            contraseñaactual.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            contraseñaactual.ForeColor = Color.White;
            contraseñaactual.Location = new Point(42, 573);
            contraseñaactual.Margin = new Padding(4, 3, 4, 3);
            contraseñaactual.Name = "contraseñaactual";
            contraseñaactual.Size = new Size(329, 25);
            contraseñaactual.TabIndex = 7;
            contraseñaactual.UseSystemPasswordChar = true;
            // 
            // usuariotxt
            // 
            usuariotxt.BackColor = Color.FromArgb(50, 50, 50);
            usuariotxt.BorderStyle = BorderStyle.FixedSingle;
            usuariotxt.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            usuariotxt.ForeColor = Color.White;
            usuariotxt.Location = new Point(44, 111);
            usuariotxt.Margin = new Padding(4, 3, 4, 3);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(329, 25);
            usuariotxt.TabIndex = 1;
            // 
            // nombretxt
            // 
            nombretxt.BackColor = Color.FromArgb(50, 50, 50);
            nombretxt.BorderStyle = BorderStyle.FixedSingle;
            nombretxt.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nombretxt.ForeColor = Color.White;
            nombretxt.Location = new Point(43, 177);
            nombretxt.Margin = new Padding(4, 3, 4, 3);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(329, 25);
            nombretxt.TabIndex = 2;
            // 
            // apellidotxt
            // 
            apellidotxt.BackColor = Color.FromArgb(50, 50, 50);
            apellidotxt.BorderStyle = BorderStyle.FixedSingle;
            apellidotxt.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            apellidotxt.ForeColor = Color.White;
            apellidotxt.Location = new Point(44, 243);
            apellidotxt.Margin = new Padding(4, 3, 4, 3);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(329, 25);
            apellidotxt.TabIndex = 3;
            // 
            // contraseñatxt
            // 
            contraseñatxt.BackColor = Color.FromArgb(50, 50, 50);
            contraseñatxt.BorderStyle = BorderStyle.FixedSingle;
            contraseñatxt.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            contraseñatxt.ForeColor = Color.White;
            contraseñatxt.Location = new Point(43, 441);
            contraseñatxt.Margin = new Padding(4, 3, 4, 3);
            contraseñatxt.Name = "contraseñatxt";
            contraseñatxt.Size = new Size(329, 25);
            contraseñatxt.TabIndex = 5;
            // 
            // confirmarcontraseñatxt
            // 
            confirmarcontraseñatxt.BackColor = Color.FromArgb(50, 50, 50);
            confirmarcontraseñatxt.BorderStyle = BorderStyle.FixedSingle;
            confirmarcontraseñatxt.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            confirmarcontraseñatxt.ForeColor = Color.White;
            confirmarcontraseñatxt.Location = new Point(42, 507);
            confirmarcontraseñatxt.Margin = new Padding(4, 3, 4, 3);
            confirmarcontraseñatxt.Name = "confirmarcontraseñatxt";
            confirmarcontraseñatxt.Size = new Size(329, 25);
            confirmarcontraseñatxt.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 192);
            linkLabel1.Location = new Point(138, 414);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Editar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(40, 21);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(166, 23);
            label12.TabIndex = 1;
            label12.Text = "Editar mis datos";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(40, 544);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(135, 17);
            label14.TabIndex = 1;
            label14.Text = "Contraseña actual";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(40, 478);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(160, 17);
            label13.TabIndex = 1;
            label13.Text = "Confirmar contraseña";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(40, 412);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(89, 17);
            label11.TabIndex = 1;
            label11.Text = "Contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(41, 82);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 1;
            label7.Text = "Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(41, 148);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 17);
            label8.TabIndex = 1;
            label8.Text = "Nombre";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(41, 346);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(66, 17);
            label15.TabIndex = 1;
            label15.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(41, 214);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 1;
            label9.Text = "Apellido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(41, 280);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 17);
            label10.TabIndex = 1;
            label10.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 1;
            label1.Text = "Mi perfil";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Usuario;
            pictureBox1.Location = new Point(14, 84);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(337, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(336, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(337, 202);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 1;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(337, 260);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(337, 321);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 17);
            label6.TabIndex = 1;
            label6.Text = "Tipo de cuenta";
            // 
            // usuariolbl
            // 
            usuariolbl.AutoSize = true;
            usuariolbl.ForeColor = Color.White;
            usuariolbl.Location = new Point(337, 111);
            usuariolbl.Margin = new Padding(4, 0, 4, 0);
            usuariolbl.Name = "usuariolbl";
            usuariolbl.Size = new Size(46, 15);
            usuariolbl.TabIndex = 3;
            usuariolbl.Text = "usuario";
            usuariolbl.Click += usuariolbl_Click;
            // 
            // nombrelbl
            // 
            nombrelbl.AutoSize = true;
            nombrelbl.ForeColor = Color.White;
            nombrelbl.Location = new Point(337, 171);
            nombrelbl.Margin = new Padding(4, 0, 4, 0);
            nombrelbl.Name = "nombrelbl";
            nombrelbl.Size = new Size(51, 15);
            nombrelbl.TabIndex = 3;
            nombrelbl.Text = "Nombre";
            // 
            // apellidolbl
            // 
            apellidolbl.AutoSize = true;
            apellidolbl.ForeColor = Color.White;
            apellidolbl.Location = new Point(337, 233);
            apellidolbl.Margin = new Padding(4, 0, 4, 0);
            apellidolbl.Name = "apellidolbl";
            apellidolbl.Size = new Size(51, 15);
            apellidolbl.TabIndex = 3;
            apellidolbl.Text = "Apellido";
            // 
            // emailbl
            // 
            emailbl.AutoSize = true;
            emailbl.ForeColor = Color.White;
            emailbl.Location = new Point(337, 292);
            emailbl.Margin = new Padding(4, 0, 4, 0);
            emailbl.Name = "emailbl";
            emailbl.Size = new Size(36, 15);
            emailbl.TabIndex = 3;
            emailbl.Text = "Email";
            // 
            // tipocuentalbl
            // 
            tipocuentalbl.AutoSize = true;
            tipocuentalbl.ForeColor = Color.White;
            tipocuentalbl.Location = new Point(337, 353);
            tipocuentalbl.Margin = new Padding(4, 0, 4, 0);
            tipocuentalbl.Name = "tipocuentalbl";
            tipocuentalbl.Size = new Size(85, 15);
            tipocuentalbl.TabIndex = 3;
            tipocuentalbl.Text = "Tipo de cuenta";
            // 
            // cerrarbtn
            // 
            cerrarbtn.BackColor = Color.FromArgb(41, 41, 41);
            cerrarbtn.BackgroundImageLayout = ImageLayout.Center;
            cerrarbtn.FlatStyle = FlatStyle.Popup;
            cerrarbtn.ForeColor = Color.White;
            cerrarbtn.ImeMode = ImeMode.NoControl;
            cerrarbtn.Location = new Point(14, 25);
            cerrarbtn.Margin = new Padding(4, 3, 4, 3);
            cerrarbtn.Name = "cerrarbtn";
            cerrarbtn.Size = new Size(29, 28);
            cerrarbtn.TabIndex = 41;
            cerrarbtn.Text = "X";
            cerrarbtn.TextImageRelation = TextImageRelation.ImageAboveText;
            cerrarbtn.UseVisualStyleBackColor = false;
            cerrarbtn.Click += cerrarbtn_Click;
            // 
            // editarbtn
            // 
            editarbtn.BackColor = Color.FromArgb(50, 50, 50);
            editarbtn.FlatStyle = FlatStyle.Popup;
            editarbtn.ForeColor = Color.White;
            editarbtn.Location = new Point(229, 594);
            editarbtn.Margin = new Padding(4, 3, 4, 3);
            editarbtn.Name = "editarbtn";
            editarbtn.Size = new Size(118, 43);
            editarbtn.TabIndex = 10;
            editarbtn.Text = "Editar";
            editarbtn.UseVisualStyleBackColor = false;
            editarbtn.Click += button1_Click;
            // 
            // PerfildeUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1049, 706);
            Controls.Add(editarbtn);
            Controls.Add(cerrarbtn);
            Controls.Add(tipocuentalbl);
            Controls.Add(emailbl);
            Controls.Add(nombrelbl);
            Controls.Add(apellidolbl);
            Controls.Add(usuariolbl);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PerfildeUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PerfildeUsuario";
            Load += PerfildeUsuario_Load;
            MouseDown += PerfildeUsuario_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label usuariolbl;
        private Label nombrelbl;
        private Label label12;
        private Label apellidolbl;
        private Label emailbl;
        private Label tipocuentalbl;
        private Button cerrarbtn;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private LinkLabel linkLabel1;
        private TextBox confirmarcontraseñatxt;
        private TextBox contraseñaactual;
        private TextBox contraseñatxt;
        private TextBox emailtxt;
        private TextBox usuariotxt;
        private TextBox nombretxt;
        private TextBox apellidotxt;
        private Button editarbtn;
        private Button Aceptar;
        private Button Cancelar;
        private TextBox telefonotxt;
        private Label label15;
    }
}