using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nombretxt = new TextBox();
            apellidotxt = new TextBox();
            usuariotxt = new TextBox();
            contrasenatxt = new TextBox();
            emailtxt = new TextBox();
            label7 = new Label();
            Ojo = new Button();
            pictureBox1 = new PictureBox();
            pctNombre = new PictureBox();
            pctApellido = new PictureBox();
            pctUsuario = new PictureBox();
            pctContraseña = new PictureBox();
            pctMail = new PictureBox();
            button1 = new Button();
            btnRegistrarse = new Button();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            telefonotxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctApellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctContraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctMail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(474, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 23);
            label1.TabIndex = 2;
            label1.Text = "REGISTRESE AQUÍ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(401, 293);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 18);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(614, 293);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 18);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(401, 360);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 18);
            label4.TabIndex = 5;
            label4.Text = "Correo Electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(614, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 6;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(401, 215);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 18);
            label6.TabIndex = 7;
            label6.Text = "Nombre";
            // 
            // nombretxt
            // 
            nombretxt.BackColor = Color.FromArgb(41, 41, 41);
            nombretxt.BorderStyle = BorderStyle.None;
            nombretxt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nombretxt.ForeColor = Color.White;
            nombretxt.Location = new Point(405, 239);
            nombretxt.Margin = new Padding(4, 3, 4, 3);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(161, 20);
            nombretxt.TabIndex = 1;
            nombretxt.KeyPress += nombretxt_KeyPress;
            // 
            // apellidotxt
            // 
            apellidotxt.BackColor = Color.FromArgb(41, 41, 41);
            apellidotxt.BorderStyle = BorderStyle.None;
            apellidotxt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            apellidotxt.ForeColor = Color.White;
            apellidotxt.Location = new Point(617, 239);
            apellidotxt.Margin = new Padding(4, 3, 4, 3);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(174, 20);
            apellidotxt.TabIndex = 2;
            apellidotxt.KeyPress += apellidotxt_KeyPress;
            // 
            // usuariotxt
            // 
            usuariotxt.BackColor = Color.FromArgb(41, 41, 41);
            usuariotxt.BorderStyle = BorderStyle.None;
            usuariotxt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usuariotxt.ForeColor = Color.White;
            usuariotxt.Location = new Point(405, 318);
            usuariotxt.Margin = new Padding(4, 3, 4, 3);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(161, 20);
            usuariotxt.TabIndex = 3;
            // 
            // contrasenatxt
            // 
            contrasenatxt.BackColor = Color.FromArgb(41, 41, 41);
            contrasenatxt.BorderStyle = BorderStyle.None;
            contrasenatxt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contrasenatxt.ForeColor = Color.White;
            contrasenatxt.Location = new Point(617, 318);
            contrasenatxt.Margin = new Padding(4, 3, 4, 3);
            contrasenatxt.Name = "contrasenatxt";
            contrasenatxt.Size = new Size(174, 20);
            contrasenatxt.TabIndex = 4;
            contrasenatxt.UseSystemPasswordChar = true;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.FromArgb(41, 41, 41);
            emailtxt.BorderStyle = BorderStyle.None;
            emailtxt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.ForeColor = Color.White;
            emailtxt.Location = new Point(405, 391);
            emailtxt.Margin = new Padding(4, 3, 4, 3);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(351, 20);
            emailtxt.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(614, 345);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(168, 30);
            label7.TabIndex = 20;
            label7.Text = "*Debe incluir letras y numeros \r\n          (6-15 caracteres)";
            // 
            // Ojo
            // 
            Ojo.BackgroundImage = (Image)resources.GetObject("Ojo.BackgroundImage");
            Ojo.BackgroundImageLayout = ImageLayout.Stretch;
            Ojo.FlatStyle = FlatStyle.Flat;
            Ojo.ForeColor = Color.FromArgb(30, 30, 30);
            Ojo.Location = new Point(794, 316);
            Ojo.Margin = new Padding(4, 3, 4, 3);
            Ojo.Name = "Ojo";
            Ojo.Size = new Size(34, 35);
            Ojo.TabIndex = 5;
            Ojo.UseVisualStyleBackColor = true;
            Ojo.Click += Ojo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 123);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // pctNombre
            // 
            pctNombre.Location = new Point(405, 240);
            pctNombre.Margin = new Padding(4, 3, 4, 3);
            pctNombre.Name = "pctNombre";
            pctNombre.Size = new Size(161, 23);
            pctNombre.TabIndex = 15;
            pctNombre.TabStop = false;
            // 
            // pctApellido
            // 
            pctApellido.Location = new Point(617, 240);
            pctApellido.Margin = new Padding(4, 3, 4, 3);
            pctApellido.Name = "pctApellido";
            pctApellido.Size = new Size(174, 23);
            pctApellido.TabIndex = 16;
            pctApellido.TabStop = false;
            // 
            // pctUsuario
            // 
            pctUsuario.Location = new Point(405, 321);
            pctUsuario.Margin = new Padding(4, 3, 4, 3);
            pctUsuario.Name = "pctUsuario";
            pctUsuario.Size = new Size(161, 23);
            pctUsuario.TabIndex = 17;
            pctUsuario.TabStop = false;
            // 
            // pctContraseña
            // 
            pctContraseña.Location = new Point(617, 321);
            pctContraseña.Margin = new Padding(4, 3, 4, 3);
            pctContraseña.Name = "pctContraseña";
            pctContraseña.Size = new Size(174, 23);
            pctContraseña.TabIndex = 18;
            pctContraseña.TabStop = false;
            // 
            // pctMail
            // 
            pctMail.Location = new Point(405, 395);
            pctMail.Margin = new Padding(4, 3, 4, 3);
            pctMail.Name = "pctMail";
            pctMail.Size = new Size(351, 23);
            pctMail.TabIndex = 19;
            pctMail.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 41, 41);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(855, 1);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(29, 28);
            button1.TabIndex = 20;
            button1.TabStop = false;
            button1.Text = "X";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(45, 45, 45);
            btnRegistrarse.FlatStyle = FlatStyle.Popup;
            btnRegistrarse.ForeColor = SystemColors.ControlDark;
            btnRegistrarse.Location = new Point(506, 510);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(131, 33);
            btnRegistrarse.TabIndex = 8;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnAceptar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(401, 439);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 18);
            label8.TabIndex = 5;
            label8.Text = "Telefono";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(405, 464);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 23);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // telefonotxt
            // 
            telefonotxt.BackColor = Color.FromArgb(41, 41, 41);
            telefonotxt.BorderStyle = BorderStyle.None;
            telefonotxt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            telefonotxt.ForeColor = Color.White;
            telefonotxt.Location = new Point(405, 460);
            telefonotxt.Margin = new Padding(4, 3, 4, 3);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(351, 20);
            telefonotxt.TabIndex = 7;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(886, 590);
            Controls.Add(btnRegistrarse);
            Controls.Add(button1);
            Controls.Add(Ojo);
            Controls.Add(label7);
            Controls.Add(telefonotxt);
            Controls.Add(emailtxt);
            Controls.Add(contrasenatxt);
            Controls.Add(usuariotxt);
            Controls.Add(apellidotxt);
            Controls.Add(nombretxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pctNombre);
            Controls.Add(pctApellido);
            Controls.Add(pctUsuario);
            Controls.Add(pictureBox2);
            Controls.Add(pctContraseña);
            Controls.Add(pctMail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Registro_Load;
            MouseDown += Registro_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctApellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctContraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctMail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nombretxt;
        private TextBox apellidotxt;
        private TextBox usuariotxt;
        private TextBox contrasenatxt;
        private TextBox emailtxt;
        private PictureBox pctNombre;
        private PictureBox pctApellido;
        private PictureBox pctUsuario;
        private PictureBox pctContraseña;
        private PictureBox pctMail;
        private Label label7;
        private Button Ojo;
        private Button button1;
        private Button btnRegistrarse;
        private Label label8;
        private PictureBox pictureBox2;
        private TextBox telefonotxt;
    }
}