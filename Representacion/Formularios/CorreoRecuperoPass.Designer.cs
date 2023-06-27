namespace Representacion.Formularios
{
    partial class CorreoRecuperoPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorreoRecuperoPass));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.pctCorreo = new System.Windows.Forms.PictureBox();
            this.Aceptarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Cerrar = new System.Windows.Forms.Button();
            this.lblErrorMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(395, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "INGRESE SU CORREO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Correo.Font = new System.Drawing.Font("Verdana", 21F);
            this.Correo.ForeColor = System.Drawing.Color.Gray;
            this.Correo.Location = new System.Drawing.Point(330, 165);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(387, 35);
            this.Correo.TabIndex = 25;
            this.Correo.Text = "Correo";
            this.Correo.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            this.Correo.Enter += new System.EventHandler(this.Correo_Enter);
            this.Correo.Leave += new System.EventHandler(this.Correo_Leave);
            // 
            // pctCorreo
            // 
            this.pctCorreo.Location = new System.Drawing.Point(330, 168);
            this.pctCorreo.Name = "pctCorreo";
            this.pctCorreo.Size = new System.Drawing.Size(377, 35);
            this.pctCorreo.TabIndex = 31;
            this.pctCorreo.TabStop = false;
            // 
            // Aceptarbtn
            // 
            this.Aceptarbtn.Activecolor = System.Drawing.Color.Transparent;
            this.Aceptarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Aceptarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Aceptarbtn.BorderRadius = 0;
            this.Aceptarbtn.ButtonText = "Aceptar";
            this.Aceptarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aceptarbtn.DisabledColor = System.Drawing.Color.Gray;
            this.Aceptarbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Aceptarbtn.Iconimage = null;
            this.Aceptarbtn.Iconimage_right = null;
            this.Aceptarbtn.Iconimage_right_Selected = null;
            this.Aceptarbtn.Iconimage_Selected = null;
            this.Aceptarbtn.IconMarginLeft = 0;
            this.Aceptarbtn.IconMarginRight = 0;
            this.Aceptarbtn.IconRightVisible = true;
            this.Aceptarbtn.IconRightZoom = 0D;
            this.Aceptarbtn.IconVisible = true;
            this.Aceptarbtn.IconZoom = 90D;
            this.Aceptarbtn.IsTab = false;
            this.Aceptarbtn.Location = new System.Drawing.Point(423, 254);
            this.Aceptarbtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Aceptarbtn.Name = "Aceptarbtn";
            this.Aceptarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Aceptarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Aceptarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Aceptarbtn.selected = false;
            this.Aceptarbtn.Size = new System.Drawing.Size(190, 29);
            this.Aceptarbtn.TabIndex = 32;
            this.Aceptarbtn.Text = "Aceptar";
            this.Aceptarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aceptarbtn.Textcolor = System.Drawing.Color.White;
            this.Aceptarbtn.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbtn.Click += new System.EventHandler(this.Aceptarbtn_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cerrar.Location = new System.Drawing.Point(715, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 24);
            this.Cerrar.TabIndex = 41;
            this.Cerrar.Text = "X";
            this.Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // lblErrorMensaje
            // 
            this.lblErrorMensaje.AutoSize = true;
            this.lblErrorMensaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMensaje.Image = global::Representacion.Properties.Resources.Error;
            this.lblErrorMensaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMensaje.Location = new System.Drawing.Point(327, 215);
            this.lblErrorMensaje.Name = "lblErrorMensaje";
            this.lblErrorMensaje.Size = new System.Drawing.Size(120, 18);
            this.lblErrorMensaje.TabIndex = 43;
            this.lblErrorMensaje.Text = "Error Mensaje";
            this.lblErrorMensaje.Visible = false;
            // 
            // CorreoRecuperoPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(741, 304);
            this.Controls.Add(this.lblErrorMensaje);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Aceptarbtn);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CorreoRecuperoPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CorreoRecuperoPass";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CorreoRecuperoPass_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.PictureBox pctCorreo;
        private Bunifu.Framework.UI.BunifuFlatButton Aceptarbtn;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Label lblErrorMensaje;
    }
}