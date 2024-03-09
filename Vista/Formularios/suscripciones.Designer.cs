using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class suscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suscripciones));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            label13 = new Label();
            label12 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            label19 = new Label();
            label15 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label20 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bunifuCards1.SuspendLayout();
            bunifuCards2.SuspendLayout();
            bunifuCards3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(509, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 17;
            label1.Text = "ELIGE TU PLAN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(428, -141);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.FromArgb(62, 62, 62);
            bunifuCards1.BorderRadius = 7;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.color = Color.FromArgb(239, 184, 16);
            bunifuCards1.Controls.Add(bunifuFlatButton1);
            bunifuCards1.Controls.Add(label5);
            bunifuCards1.Controls.Add(label4);
            bunifuCards1.Controls.Add(label3);
            bunifuCards1.Controls.Add(label6);
            bunifuCards1.Controls.Add(label2);
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.Location = new Point(89, 181);
            bunifuCards1.Margin = new Padding(4, 3, 4, 3);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.ShadowDepth = 500;
            bunifuCards1.Size = new Size(328, 318);
            bunifuCards1.TabIndex = 19;
            // 
            // bunifuFlatButton1
            // 
            bunifuFlatButton1.Activecolor = Color.FromArgb(180, 180, 180);
            bunifuFlatButton1.BackColor = Color.FromArgb(100, 100, 100);
            bunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton1.BorderRadius = 0;
            bunifuFlatButton1.ButtonText = "Seleccionar";
            bunifuFlatButton1.Cursor = Cursors.Hand;
            bunifuFlatButton1.DisabledColor = Color.Gray;
            bunifuFlatButton1.ForeColor = Color.FromArgb(230, 230, 230);
            bunifuFlatButton1.Iconcolor = Color.Transparent;
            bunifuFlatButton1.Iconimage = (Image)resources.GetObject("bunifuFlatButton1.Iconimage");
            bunifuFlatButton1.Iconimage_right = null;
            bunifuFlatButton1.Iconimage_right_Selected = null;
            bunifuFlatButton1.Iconimage_Selected = null;
            bunifuFlatButton1.IconMarginLeft = 0;
            bunifuFlatButton1.IconMarginRight = 0;
            bunifuFlatButton1.IconRightVisible = true;
            bunifuFlatButton1.IconRightZoom = 0D;
            bunifuFlatButton1.IconVisible = true;
            bunifuFlatButton1.IconZoom = 90D;
            bunifuFlatButton1.IsTab = false;
            bunifuFlatButton1.Location = new Point(83, 260);
            bunifuFlatButton1.Margin = new Padding(5, 3, 5, 3);
            bunifuFlatButton1.Name = "bunifuFlatButton1";
            bunifuFlatButton1.Normalcolor = Color.FromArgb(100, 100, 100);
            bunifuFlatButton1.OnHovercolor = Color.FromArgb(180, 180, 180);
            bunifuFlatButton1.OnHoverTextColor = Color.White;
            bunifuFlatButton1.selected = false;
            bunifuFlatButton1.Size = new Size(175, 40);
            bunifuFlatButton1.TabIndex = 27;
            bunifuFlatButton1.Text = "Seleccionar";
            bunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton1.Textcolor = Color.White;
            bunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuFlatButton1.Click += bunifuFlatButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(4, 208);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(246, 13);
            label5.TabIndex = 26;
            label5.Text = "● Imposibilidad de descargar documentos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(4, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(221, 13);
            label4.TabIndex = 25;
            label4.Text = "● Funcionalidad de busqueda limitada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(4, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(254, 13);
            label3.TabIndex = 24;
            label3.Text = "● Acceso limitado a documentos y archivos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(106, 69);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 18);
            label6.TabIndex = 23;
            label6.Text = "ARS 0/MES*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 22;
            label2.Text = "STUDY BASIC";
            // 
            // bunifuCards2
            // 
            bunifuCards2.BackColor = Color.FromArgb(62, 62, 62);
            bunifuCards2.BorderRadius = 7;
            bunifuCards2.BottomSahddow = true;
            bunifuCards2.color = Color.FromArgb(239, 184, 16);
            bunifuCards2.Controls.Add(bunifuFlatButton2);
            bunifuCards2.Controls.Add(label13);
            bunifuCards2.Controls.Add(label12);
            bunifuCards2.Controls.Add(label7);
            bunifuCards2.Controls.Add(label8);
            bunifuCards2.Controls.Add(label9);
            bunifuCards2.Controls.Add(label10);
            bunifuCards2.Controls.Add(label11);
            bunifuCards2.LeftSahddow = false;
            bunifuCards2.Location = new Point(442, 162);
            bunifuCards2.Margin = new Padding(4, 3, 4, 3);
            bunifuCards2.Name = "bunifuCards2";
            bunifuCards2.RightSahddow = true;
            bunifuCards2.ShadowDepth = 500;
            bunifuCards2.Size = new Size(328, 338);
            bunifuCards2.TabIndex = 20;
            // 
            // bunifuFlatButton2
            // 
            bunifuFlatButton2.Activecolor = Color.FromArgb(180, 180, 180);
            bunifuFlatButton2.BackColor = Color.FromArgb(100, 100, 100);
            bunifuFlatButton2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton2.BorderRadius = 0;
            bunifuFlatButton2.ButtonText = "Seleccionar";
            bunifuFlatButton2.Cursor = Cursors.Hand;
            bunifuFlatButton2.DisabledColor = Color.Gray;
            bunifuFlatButton2.ForeColor = Color.FromArgb(230, 230, 230);
            bunifuFlatButton2.Iconcolor = Color.Transparent;
            bunifuFlatButton2.Iconimage = (Image)resources.GetObject("bunifuFlatButton2.Iconimage");
            bunifuFlatButton2.Iconimage_right = null;
            bunifuFlatButton2.Iconimage_right_Selected = null;
            bunifuFlatButton2.Iconimage_Selected = null;
            bunifuFlatButton2.IconMarginLeft = 0;
            bunifuFlatButton2.IconMarginRight = 0;
            bunifuFlatButton2.IconRightVisible = true;
            bunifuFlatButton2.IconRightZoom = 0D;
            bunifuFlatButton2.IconVisible = true;
            bunifuFlatButton2.IconZoom = 90D;
            bunifuFlatButton2.IsTab = false;
            bunifuFlatButton2.Location = new Point(84, 279);
            bunifuFlatButton2.Margin = new Padding(5, 3, 5, 3);
            bunifuFlatButton2.Name = "bunifuFlatButton2";
            bunifuFlatButton2.Normalcolor = Color.FromArgb(100, 100, 100);
            bunifuFlatButton2.OnHovercolor = Color.FromArgb(180, 180, 180);
            bunifuFlatButton2.OnHoverTextColor = Color.White;
            bunifuFlatButton2.selected = false;
            bunifuFlatButton2.Size = new Size(187, 40);
            bunifuFlatButton2.TabIndex = 34;
            bunifuFlatButton2.Text = "Seleccionar";
            bunifuFlatButton2.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton2.Textcolor = Color.White;
            bunifuFlatButton2.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuFlatButton2.Click += bunifuFlatButton2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(68, 100);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(155, 18);
            label13.TabIndex = 33;
            label13.Text = "ARS 10.000/AÑO*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(14, 233);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(252, 26);
            label12.TabIndex = 32;
            label12.Text = "● Uso de una nube personal con capacidad\r\n  de almacenamiento de hasta 50GB.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(14, 204);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(235, 13);
            label7.TabIndex = 31;
            label7.Text = "● Descarga de archivos para uso offline";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(14, 175);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(231, 13);
            label8.TabIndex = 30;
            label8.Text = "● Funcionalidad avanzada de busqueda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(14, 142);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(257, 13);
            label9.TabIndex = 29;
            label9.Text = "● Acceso ilimitado a documentos y archivos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(80, 59);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 18);
            label10.TabIndex = 28;
            label10.Text = "ARS 1.000/MES*";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(59, 20);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(192, 23);
            label11.TabIndex = 27;
            label11.Text = "STUDY PREMIUM";
            // 
            // bunifuCards3
            // 
            bunifuCards3.BackColor = Color.FromArgb(62, 62, 62);
            bunifuCards3.BorderRadius = 7;
            bunifuCards3.BottomSahddow = true;
            bunifuCards3.color = Color.FromArgb(239, 184, 16);
            bunifuCards3.Controls.Add(bunifuFlatButton3);
            bunifuCards3.Controls.Add(label19);
            bunifuCards3.Controls.Add(label15);
            bunifuCards3.Controls.Add(label14);
            bunifuCards3.Controls.Add(label16);
            bunifuCards3.Controls.Add(label17);
            bunifuCards3.Controls.Add(label18);
            bunifuCards3.LeftSahddow = false;
            bunifuCards3.Location = new Point(818, 181);
            bunifuCards3.Margin = new Padding(4, 3, 4, 3);
            bunifuCards3.Name = "bunifuCards3";
            bunifuCards3.RightSahddow = true;
            bunifuCards3.ShadowDepth = 500;
            bunifuCards3.Size = new Size(328, 318);
            bunifuCards3.TabIndex = 21;
            // 
            // bunifuFlatButton3
            // 
            bunifuFlatButton3.Activecolor = Color.FromArgb(180, 180, 180);
            bunifuFlatButton3.BackColor = Color.FromArgb(100, 100, 100);
            bunifuFlatButton3.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton3.BorderRadius = 0;
            bunifuFlatButton3.ButtonText = "Seleccionar";
            bunifuFlatButton3.Cursor = Cursors.Hand;
            bunifuFlatButton3.DisabledColor = Color.Gray;
            bunifuFlatButton3.ForeColor = Color.FromArgb(230, 230, 230);
            bunifuFlatButton3.Iconcolor = Color.Transparent;
            bunifuFlatButton3.Iconimage = (Image)resources.GetObject("bunifuFlatButton3.Iconimage");
            bunifuFlatButton3.Iconimage_right = null;
            bunifuFlatButton3.Iconimage_right_Selected = null;
            bunifuFlatButton3.Iconimage_Selected = null;
            bunifuFlatButton3.IconMarginLeft = 0;
            bunifuFlatButton3.IconMarginRight = 0;
            bunifuFlatButton3.IconRightVisible = true;
            bunifuFlatButton3.IconRightZoom = 0D;
            bunifuFlatButton3.IconVisible = true;
            bunifuFlatButton3.IconZoom = 90D;
            bunifuFlatButton3.IsTab = false;
            bunifuFlatButton3.Location = new Point(89, 260);
            bunifuFlatButton3.Margin = new Padding(5, 3, 5, 3);
            bunifuFlatButton3.Name = "bunifuFlatButton3";
            bunifuFlatButton3.Normalcolor = Color.FromArgb(100, 100, 100);
            bunifuFlatButton3.OnHovercolor = Color.FromArgb(180, 180, 180);
            bunifuFlatButton3.OnHoverTextColor = Color.White;
            bunifuFlatButton3.selected = false;
            bunifuFlatButton3.Size = new Size(176, 40);
            bunifuFlatButton3.TabIndex = 41;
            bunifuFlatButton3.Text = "Seleccionar";
            bunifuFlatButton3.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton3.Textcolor = Color.White;
            bunifuFlatButton3.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuFlatButton3.Click += bunifuFlatButton3_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Transparent;
            label19.Location = new Point(77, 100);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(145, 18);
            label19.TabIndex = 40;
            label19.Text = "ARS 3.500/AÑO*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(16, 178);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(221, 13);
            label15.TabIndex = 39;
            label15.Text = "● Funcionalidad de busqueda limitada";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(16, 208);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(235, 13);
            label14.TabIndex = 37;
            label14.Text = "● Descarga de archivos para uso offline";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Transparent;
            label16.Location = new Point(16, 150);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(257, 13);
            label16.TabIndex = 35;
            label16.Text = "● Acceso ilimitado a documentos y archivos";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Transparent;
            label17.Location = new Point(89, 57);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(126, 18);
            label17.TabIndex = 34;
            label17.Text = "ARS 500/MES*";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(76, 17);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(165, 23);
            label18.TabIndex = 33;
            label18.Text = "STUDY PLUS   ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Transparent;
            label20.Location = new Point(315, 520);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(532, 13);
            label20.TabIndex = 25;
            label20.Text = "*El precio puede variar dependiendo del metodo de pago. Podrian aplicar caros de terceros";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 41, 41);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(1178, 1);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(29, 28);
            button1.TabIndex = 40;
            button1.Text = "X";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // suscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1209, 562);
            Controls.Add(button1);
            Controls.Add(label20);
            Controls.Add(bunifuCards3);
            Controls.Add(bunifuCards2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(bunifuCards1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "suscripciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            MouseDown += suscripciones_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bunifuCards1.ResumeLayout(false);
            bunifuCards1.PerformLayout();
            bunifuCards2.ResumeLayout(false);
            bunifuCards2.PerformLayout();
            bunifuCards3.ResumeLayout(false);
            bunifuCards3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label13;
        private Label label12;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label15;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        internal Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Button button1;
    }
}