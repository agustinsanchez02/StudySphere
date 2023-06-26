namespace Representacion
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
            this.IniciarSesionbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblErrorMensaje = new System.Windows.Forms.Label();
            this.Ojo = new System.Windows.Forms.Button();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.Contraseña.TabIndex = 25;
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
            this.Usuario.TabIndex = 24;
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
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.linkLabel1.Location = new System.Drawing.Point(416, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 17);
            this.linkLabel1.TabIndex = 29;
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
            this.IniciarSesionbtn.Activecolor = System.Drawing.Color.Transparent;
            this.IniciarSesionbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.IniciarSesionbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IniciarSesionbtn.BorderRadius = 0;
            this.IniciarSesionbtn.ButtonText = "Iniciar sesión";
            this.IniciarSesionbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarSesionbtn.DisabledColor = System.Drawing.Color.Gray;
            this.IniciarSesionbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.IniciarSesionbtn.Iconimage = null;
            this.IniciarSesionbtn.Iconimage_right = null;
            this.IniciarSesionbtn.Iconimage_right_Selected = null;
            this.IniciarSesionbtn.Iconimage_Selected = null;
            this.IniciarSesionbtn.IconMarginLeft = 0;
            this.IniciarSesionbtn.IconMarginRight = 0;
            this.IniciarSesionbtn.IconRightVisible = true;
            this.IniciarSesionbtn.IconRightZoom = 0D;
            this.IniciarSesionbtn.IconVisible = true;
            this.IniciarSesionbtn.IconZoom = 90D;
            this.IniciarSesionbtn.IsTab = false;
            this.IniciarSesionbtn.Location = new System.Drawing.Point(417, 339);
            this.IniciarSesionbtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.IniciarSesionbtn.Name = "IniciarSesionbtn";
            this.IniciarSesionbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.IniciarSesionbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.IniciarSesionbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.IniciarSesionbtn.selected = false;
            this.IniciarSesionbtn.Size = new System.Drawing.Size(190, 29);
            this.IniciarSesionbtn.TabIndex = 28;
            this.IniciarSesionbtn.Text = "Iniciar sesión";
            this.IniciarSesionbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IniciarSesionbtn.Textcolor = System.Drawing.Color.White;
            this.IniciarSesionbtn.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionbtn.Click += new System.EventHandler(this.IniciarSesionbtn_Click);
            // 
            // lblErrorMensaje
            // 
            this.lblErrorMensaje.AutoSize = true;
            this.lblErrorMensaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMensaje.Image = global::Representacion.Properties.Resources.Error;
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
            this.Ojo.TabIndex = 41;
            this.Ojo.UseVisualStyleBackColor = true;
            this.Ojo.Click += new System.EventHandler(this.Ojo_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Registrarse";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage_right")));
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(591, 0);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(143, 26);
            this.bunifuFlatButton2.TabIndex = 27;
            this.bunifuFlatButton2.Text = "Registrarse";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
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
            this.Controls.Add(this.lblErrorMensaje);
            this.Controls.Add(this.Ojo);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.IniciarSesionbtn);
            this.Controls.Add(this.bunifuFlatButton2);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iniciar_sesion_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pctCorreo;
        private System.Windows.Forms.PictureBox pctContraseña;
        private System.Windows.Forms.Button Cerrar;
        public System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Button Ojo;
        private Bunifu.Framework.UI.BunifuFlatButton IniciarSesionbtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label lblErrorMensaje;
    }
}