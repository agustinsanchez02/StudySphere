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
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.IniciarSesionbtn = new System.Windows.Forms.Button();
            this.Registrarsebtn = new System.Windows.Forms.Button();
            this.lblErrorMensaje = new System.Windows.Forms.Label();
            this.Ojo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctCorreo = new System.Windows.Forms.PictureBox();
            this.pctContraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseña.Font = new System.Drawing.Font("Verdana", 21F);
            this.Contraseña.ForeColor = System.Drawing.Color.Gray;
            this.Contraseña.Location = new System.Drawing.Point(356, 237);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(378, 35);
            this.Contraseña.TabIndex = 2;
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.Contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Verdana", 21F);
            this.Usuario.ForeColor = System.Drawing.Color.Gray;
            this.Usuario.Location = new System.Drawing.Point(357, 171);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(377, 35);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario/Mail";
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "INICIE SESIÓN AQUÍ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 10F);
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(464, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste tu contraseña?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cerrar.Location = new System.Drawing.Point(756, 2);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 24);
            this.Cerrar.TabIndex = 40;
            this.Cerrar.Text = "X";
            this.Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // IniciarSesionbtn
            // 
            this.IniciarSesionbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.IniciarSesionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesionbtn.ForeColor = System.Drawing.Color.Gray;
            this.IniciarSesionbtn.Location = new System.Drawing.Point(490, 328);
            this.IniciarSesionbtn.Name = "IniciarSesionbtn";
            this.IniciarSesionbtn.Size = new System.Drawing.Size(112, 34);
            this.IniciarSesionbtn.TabIndex = 4;
            this.IniciarSesionbtn.Text = "Iniciar Sesión";
            this.IniciarSesionbtn.UseVisualStyleBackColor = false;
            this.IniciarSesionbtn.Click += new System.EventHandler(this.IniciarSesionbtn_Click);
            // 
            // Registrarsebtn
            // 
            this.Registrarsebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Registrarsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registrarsebtn.ForeColor = System.Drawing.Color.White;
            this.Registrarsebtn.Location = new System.Drawing.Point(638, 2);
            this.Registrarsebtn.Name = "Registrarsebtn";
            this.Registrarsebtn.Size = new System.Drawing.Size(112, 34);
            this.Registrarsebtn.TabIndex = 6;
            this.Registrarsebtn.Text = "Registrarse";
            this.Registrarsebtn.UseVisualStyleBackColor = false;
            this.Registrarsebtn.Click += new System.EventHandler(this.Registrarsebtn_Click);
            // 
            // lblErrorMensaje
            // 
            this.lblErrorMensaje.AutoSize = true;
            this.lblErrorMensaje.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblErrorMensaje.Image = global::Vista.Properties.Resources.Error;
            this.lblErrorMensaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMensaje.Location = new System.Drawing.Point(354, 288);
            this.lblErrorMensaje.Name = "lblErrorMensaje";
            this.lblErrorMensaje.Size = new System.Drawing.Size(120, 18);
            this.lblErrorMensaje.TabIndex = 42;
            this.lblErrorMensaje.Text = "Error Mensaje";
            this.lblErrorMensaje.Visible = false;
            // 
            // Ojo
            // 
            this.Ojo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ojo.BackgroundImage")));
            this.Ojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ojo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Ojo.Location = new System.Drawing.Point(740, 245);
            this.Ojo.Name = "Ojo";
            this.Ojo.Size = new System.Drawing.Size(29, 30);
            this.Ojo.TabIndex = 3;
            this.Ojo.UseVisualStyleBackColor = true;
            this.Ojo.Click += new System.EventHandler(this.Ojo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pctCorreo
            // 
            this.pctCorreo.Location = new System.Drawing.Point(357, 175);
            this.pctCorreo.Name = "pctCorreo";
            this.pctCorreo.Size = new System.Drawing.Size(377, 35);
            this.pctCorreo.TabIndex = 30;
            this.pctCorreo.TabStop = false;
            // 
            // pctContraseña
            // 
            this.pctContraseña.Location = new System.Drawing.Point(356, 241);
            this.pctContraseña.Name = "pctContraseña";
            this.pctContraseña.Size = new System.Drawing.Size(378, 35);
            this.pctContraseña.TabIndex = 31;
            this.pctContraseña.TabStop = false;
            // 
            // iniciar_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.Registrarsebtn);
            this.Controls.Add(this.IniciarSesionbtn);
            this.Controls.Add(this.lblErrorMensaje);
            this.Controls.Add(this.Ojo);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctCorreo);
            this.Controls.Add(this.pctContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "iniciar_sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.iniciar_sesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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