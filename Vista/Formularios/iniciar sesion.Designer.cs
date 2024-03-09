using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class iniciar_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iniciar_sesion));
            Contraseña = new TextBox();
            Usuario = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            Cerrar = new Button();
            lblErrorMensaje = new Label();
            Ojo = new Button();
            pictureBox1 = new PictureBox();
            pctCorreo = new PictureBox();
            pctContraseña = new PictureBox();
            IniciarSesionbtn = new Button();
            Registrarsebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctCorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctContraseña).BeginInit();
            SuspendLayout();
            // 
            // Contraseña
            // 
            Contraseña.BackColor = Color.FromArgb(41, 41, 41);
            Contraseña.BorderStyle = BorderStyle.None;
            Contraseña.Font = new Font("Verdana", 21F, FontStyle.Regular, GraphicsUnit.Point);
            Contraseña.ForeColor = Color.Gray;
            Contraseña.Location = new Point(415, 273);
            Contraseña.Margin = new Padding(4, 3, 4, 3);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(441, 35);
            Contraseña.TabIndex = 2;
            Contraseña.Text = "Contraseña";
            Contraseña.Enter += Contraseña_Enter;
            Contraseña.Leave += Contraseña_Leave;
            // 
            // Usuario
            // 
            Usuario.BackColor = Color.FromArgb(41, 41, 41);
            Usuario.BorderStyle = BorderStyle.None;
            Usuario.Font = new Font("Verdana", 21F, FontStyle.Regular, GraphicsUnit.Point);
            Usuario.ForeColor = Color.Gray;
            Usuario.Location = new Point(416, 197);
            Usuario.Margin = new Padding(4, 3, 4, 3);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(440, 35);
            Usuario.TabIndex = 1;
            Usuario.Text = "Usuario/Mail";
            Usuario.Enter += Usuario_Enter;
            Usuario.Leave += Usuario_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(482, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 23);
            label1.TabIndex = 16;
            label1.Text = "INICIE SESIÓN AQUÍ";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(255, 255, 192);
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(541, 469);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(191, 17);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu contraseña?";
            linkLabel1.VisitedLinkColor = Color.Silver;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.FromArgb(41, 41, 41);
            Cerrar.BackgroundImageLayout = ImageLayout.Center;
            Cerrar.FlatStyle = FlatStyle.Popup;
            Cerrar.ForeColor = SystemColors.ButtonHighlight;
            Cerrar.ImeMode = ImeMode.NoControl;
            Cerrar.Location = new Point(882, 2);
            Cerrar.Margin = new Padding(4, 3, 4, 3);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(29, 28);
            Cerrar.TabIndex = 40;
            Cerrar.Text = "X";
            Cerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // lblErrorMensaje
            // 
            lblErrorMensaje.AutoSize = true;
            lblErrorMensaje.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorMensaje.Image = Properties.Resources.Error;
            lblErrorMensaje.ImageAlign = ContentAlignment.MiddleLeft;
            lblErrorMensaje.Location = new Point(413, 332);
            lblErrorMensaje.Margin = new Padding(4, 0, 4, 0);
            lblErrorMensaje.Name = "lblErrorMensaje";
            lblErrorMensaje.Size = new Size(120, 18);
            lblErrorMensaje.TabIndex = 42;
            lblErrorMensaje.Text = "Error Mensaje";
            lblErrorMensaje.Visible = false;
            // 
            // Ojo
            // 
            Ojo.BackgroundImage = (Image)resources.GetObject("Ojo.BackgroundImage");
            Ojo.BackgroundImageLayout = ImageLayout.Stretch;
            Ojo.FlatStyle = FlatStyle.Flat;
            Ojo.ForeColor = Color.FromArgb(30, 30, 30);
            Ojo.Location = new Point(863, 283);
            Ojo.Margin = new Padding(4, 3, 4, 3);
            Ojo.Name = "Ojo";
            Ojo.Size = new Size(34, 35);
            Ojo.TabIndex = 3;
            Ojo.UseVisualStyleBackColor = true;
            Ojo.Click += Ojo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 519);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // pctCorreo
            // 
            pctCorreo.Location = new Point(416, 202);
            pctCorreo.Margin = new Padding(4, 3, 4, 3);
            pctCorreo.Name = "pctCorreo";
            pctCorreo.Size = new Size(440, 40);
            pctCorreo.TabIndex = 30;
            pctCorreo.TabStop = false;
            // 
            // pctContraseña
            // 
            pctContraseña.Location = new Point(415, 278);
            pctContraseña.Margin = new Padding(4, 3, 4, 3);
            pctContraseña.Name = "pctContraseña";
            pctContraseña.Size = new Size(441, 40);
            pctContraseña.TabIndex = 31;
            pctContraseña.TabStop = false;
            // 
            // IniciarSesionbtn
            // 
            IniciarSesionbtn.BackColor = Color.FromArgb(41, 41, 41);
            IniciarSesionbtn.FlatStyle = FlatStyle.Flat;
            IniciarSesionbtn.ForeColor = Color.Gray;
            IniciarSesionbtn.Location = new Point(572, 378);
            IniciarSesionbtn.Name = "IniciarSesionbtn";
            IniciarSesionbtn.Size = new Size(131, 39);
            IniciarSesionbtn.TabIndex = 4;
            IniciarSesionbtn.Text = "Iniciar Sesión";
            IniciarSesionbtn.UseVisualStyleBackColor = false;
            IniciarSesionbtn.Click += IniciarSesionbtn_Click_1;
            // 
            // Registrarsebtn
            // 
            Registrarsebtn.BackColor = Color.FromArgb(30, 30, 30);
            Registrarsebtn.FlatStyle = FlatStyle.Popup;
            Registrarsebtn.ForeColor = Color.White;
            Registrarsebtn.Location = new Point(744, 2);
            Registrarsebtn.Name = "Registrarsebtn";
            Registrarsebtn.Size = new Size(131, 39);
            Registrarsebtn.TabIndex = 6;
            Registrarsebtn.Text = "Registrarse";
            Registrarsebtn.UseVisualStyleBackColor = false;
            Registrarsebtn.Click += Registrarsebtn_Click;
            // 
            // iniciar_sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(915, 519);
            Controls.Add(Registrarsebtn);
            Controls.Add(IniciarSesionbtn);
            Controls.Add(lblErrorMensaje);
            Controls.Add(Ojo);
            Controls.Add(Cerrar);
            Controls.Add(linkLabel1);
            Controls.Add(Contraseña);
            Controls.Add(Usuario);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pctCorreo);
            Controls.Add(pctContraseña);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "iniciar_sesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            MouseDown += iniciar_sesion_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctCorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctContraseña).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Contraseña;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private PictureBox pctCorreo;
        private PictureBox pctContraseña;
        private Button Cerrar;
        public TextBox Usuario;
        private Button Ojo;
        private Label lblErrorMensaje;
        private Button IniciarSesionbtn;
        private Button Registrarsebtn;
    }
}