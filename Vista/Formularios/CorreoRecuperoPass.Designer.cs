using System.Drawing;
using System.Windows.Forms;

namespace Vista
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Correo = new TextBox();
            pctCorreo = new PictureBox();
            Cerrar = new Button();
            lblErrorMensaje = new Label();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctCorreo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(461, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 23);
            label1.TabIndex = 17;
            label1.Text = "INGRESE SU CORREO";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // Correo
            // 
            Correo.BackColor = Color.FromArgb(41, 41, 41);
            Correo.BorderStyle = BorderStyle.None;
            Correo.Font = new Font("Verdana", 21F, FontStyle.Regular, GraphicsUnit.Point);
            Correo.ForeColor = Color.Gray;
            Correo.Location = new Point(385, 190);
            Correo.Margin = new Padding(4, 3, 4, 3);
            Correo.Name = "Correo";
            Correo.Size = new Size(451, 35);
            Correo.TabIndex = 25;
            Correo.Text = "Correo";
            Correo.TextChanged += Usuario_TextChanged;
            Correo.Enter += Correo_Enter;
            Correo.Leave += Correo_Leave;
            // 
            // pctCorreo
            // 
            pctCorreo.Location = new Point(385, 194);
            pctCorreo.Margin = new Padding(4, 3, 4, 3);
            pctCorreo.Name = "pctCorreo";
            pctCorreo.Size = new Size(440, 40);
            pctCorreo.TabIndex = 31;
            pctCorreo.TabStop = false;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.FromArgb(41, 41, 41);
            Cerrar.BackgroundImageLayout = ImageLayout.Center;
            Cerrar.FlatStyle = FlatStyle.Popup;
            Cerrar.ForeColor = SystemColors.ButtonHighlight;
            Cerrar.ImeMode = ImeMode.NoControl;
            Cerrar.Location = new Point(834, 0);
            Cerrar.Margin = new Padding(4, 3, 4, 3);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(29, 28);
            Cerrar.TabIndex = 41;
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
            lblErrorMensaje.Location = new Point(382, 248);
            lblErrorMensaje.Margin = new Padding(4, 0, 4, 0);
            lblErrorMensaje.Name = "lblErrorMensaje";
            lblErrorMensaje.Size = new Size(120, 18);
            lblErrorMensaje.TabIndex = 43;
            lblErrorMensaje.Text = "Error Mensaje";
            lblErrorMensaje.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(41, 41, 41);
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(546, 280);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(153, 44);
            btnAceptar.TabIndex = 44;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // CorreoRecuperoPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(864, 351);
            Controls.Add(btnAceptar);
            Controls.Add(lblErrorMensaje);
            Controls.Add(Cerrar);
            Controls.Add(Correo);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pctCorreo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CorreoRecuperoPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CorreoRecuperoPass";
            Load += CorreoRecuperoPass_Load;
            MouseDown += CorreoRecuperoPass_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctCorreo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        public TextBox Correo;
        private PictureBox pctCorreo;
        private Button Cerrar;
        private Label lblErrorMensaje;
        private Button btnAceptar;
    }
}