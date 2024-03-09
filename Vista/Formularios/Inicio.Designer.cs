using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            Buscartxt = new TextBox();
            label7 = new Label();
            lblTipoCuenta = new Label();
            pictureBox6 = new PictureBox();
            CerrarSesionBTN = new Button();
            SubirArchivoBTN = new Button();
            Buscarbtn = new Button();
            lblnombre = new Label();
            lblmail = new Label();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            verArchivobtn = new Button();
            Descargarbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 41, 41);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(1210, -1);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(29, 28);
            button1.TabIndex = 40;
            button1.Text = "X";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(62, 62, 62);
            label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 126);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 5;
            label1.Text = "Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(62, 62, 62);
            label2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 7;
            label2.Text = "Materias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(62, 62, 62);
            label3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 282);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 11;
            label3.Text = "Universidades";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(62, 62, 62);
            label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 347);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 14;
            label4.Text = "Mis libros";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 62, 62);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -5);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 854);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(77, 177);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 14);
            label8.TabIndex = 47;
            label8.Text = "Mi Biblioteca";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(62, 62, 62);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.delante;
            button5.Location = new Point(184, 338);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(63, 33);
            button5.TabIndex = 44;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(62, 62, 62);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.delante;
            button4.Location = new Point(184, 274);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(63, 33);
            button4.TabIndex = 44;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(62, 62, 62);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.delante;
            button3.Location = new Point(184, 210);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(63, 33);
            button3.TabIndex = 44;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.Archivo;
            pictureBox5.Location = new Point(10, 210);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 32);
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.casa;
            pictureBox2.Location = new Point(10, 119);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Image = Properties.Resources.Escuela;
            label6.Location = new Point(4, 275);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 31);
            label6.TabIndex = 43;
            label6.Text = "   ";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Libros;
            pictureBox3.Location = new Point(10, 339);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 32);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-24, -17);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Buscartxt
            // 
            Buscartxt.BackColor = Color.FromArgb(45, 45, 45);
            Buscartxt.BorderStyle = BorderStyle.FixedSingle;
            Buscartxt.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Buscartxt.ForeColor = Color.FromArgb(158, 169, 181);
            Buscartxt.Location = new Point(327, 142);
            Buscartxt.Margin = new Padding(4, 3, 4, 3);
            Buscartxt.Name = "Buscartxt";
            Buscartxt.Size = new Size(818, 26);
            Buscartxt.TabIndex = 44;
            Buscartxt.Text = "Buscar libros o materias";
            Buscartxt.Enter += Buscartxt_Enter;
            Buscartxt.Leave += Buscartxt_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(258, 104);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(862, 15);
            label7.TabIndex = 45;
            label7.Text = "___________________________________________________________________________________________________________________________________________________________________________";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // lblTipoCuenta
            // 
            lblTipoCuenta.AutoSize = true;
            lblTipoCuenta.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCuenta.ForeColor = Color.White;
            lblTipoCuenta.Location = new Point(383, 13);
            lblTipoCuenta.Margin = new Padding(4, 0, 4, 0);
            lblTipoCuenta.Name = "lblTipoCuenta";
            lblTipoCuenta.Size = new Size(100, 14);
            lblTipoCuenta.TabIndex = 48;
            lblTipoCuenta.Text = "Tipo de cuenta";
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.Image = Properties.Resources.USuario__2___1_;
            pictureBox6.Location = new Point(261, 14);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(0, 87);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 47;
            pictureBox6.TabStop = false;
            // 
            // CerrarSesionBTN
            // 
            CerrarSesionBTN.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            CerrarSesionBTN.Image = Properties.Resources.Salir;
            CerrarSesionBTN.ImageAlign = ContentAlignment.MiddleLeft;
            CerrarSesionBTN.Location = new Point(1053, 25);
            CerrarSesionBTN.Margin = new Padding(4, 3, 4, 3);
            CerrarSesionBTN.Name = "CerrarSesionBTN";
            CerrarSesionBTN.Size = new Size(121, 40);
            CerrarSesionBTN.TabIndex = 46;
            CerrarSesionBTN.Text = "     Cerrar sesión";
            CerrarSesionBTN.UseVisualStyleBackColor = true;
            CerrarSesionBTN.Click += CerrarSesionBTN_Click;
            // 
            // SubirArchivoBTN
            // 
            SubirArchivoBTN.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            SubirArchivoBTN.Image = Properties.Resources.Añadir;
            SubirArchivoBTN.ImageAlign = ContentAlignment.MiddleLeft;
            SubirArchivoBTN.Location = new Point(891, 25);
            SubirArchivoBTN.Margin = new Padding(4, 3, 4, 3);
            SubirArchivoBTN.Name = "SubirArchivoBTN";
            SubirArchivoBTN.Size = new Size(121, 40);
            SubirArchivoBTN.TabIndex = 46;
            SubirArchivoBTN.Text = "     Subir archivo";
            SubirArchivoBTN.UseVisualStyleBackColor = true;
            SubirArchivoBTN.Click += SubirArchivoBTN_Click;
            // 
            // Buscarbtn
            // 
            Buscarbtn.BackColor = Color.FromArgb(45, 45, 45);
            Buscarbtn.FlatStyle = FlatStyle.Flat;
            Buscarbtn.Image = Properties.Resources.Buscar;
            Buscarbtn.Location = new Point(275, 134);
            Buscarbtn.Margin = new Padding(4, 3, 4, 3);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(44, 45);
            Buscarbtn.TabIndex = 43;
            Buscarbtn.UseVisualStyleBackColor = false;
            Buscarbtn.Click += Buscarbtn_Click;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombre.ForeColor = Color.White;
            lblnombre.Location = new Point(383, 37);
            lblnombre.Margin = new Padding(4, 0, 4, 0);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(56, 14);
            lblnombre.TabIndex = 48;
            lblnombre.Text = "Nombre";
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblmail.ForeColor = Color.White;
            lblmail.Location = new Point(383, 61);
            lblmail.Margin = new Padding(4, 0, 4, 0);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(40, 14);
            lblmail.TabIndex = 48;
            lblmail.Text = "Email";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 192);
            linkLabel1.Location = new Point(383, 89);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(51, 15);
            linkLabel1.TabIndex = 49;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Mi perfil";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(827, 446);
            dataGridView1.TabIndex = 50;
            // 
            // verArchivobtn
            // 
            verArchivobtn.BackColor = Color.FromArgb(45, 45, 45);
            verArchivobtn.FlatStyle = FlatStyle.Popup;
            verArchivobtn.ForeColor = SystemColors.ControlDark;
            verArchivobtn.Location = new Point(1015, 693);
            verArchivobtn.Name = "verArchivobtn";
            verArchivobtn.Size = new Size(130, 34);
            verArchivobtn.TabIndex = 51;
            verArchivobtn.Text = "Ver Archivo";
            verArchivobtn.UseVisualStyleBackColor = false;
            verArchivobtn.Click += verArchivobtn_Click;
            // 
            // Descargarbtn
            // 
            Descargarbtn.BackColor = Color.FromArgb(45, 45, 45);
            Descargarbtn.FlatStyle = FlatStyle.Popup;
            Descargarbtn.ForeColor = SystemColors.ControlDark;
            Descargarbtn.Location = new Point(861, 693);
            Descargarbtn.Name = "Descargarbtn";
            Descargarbtn.Size = new Size(130, 34);
            Descargarbtn.TabIndex = 51;
            Descargarbtn.Text = "Descargar Archivo";
            Descargarbtn.UseVisualStyleBackColor = false;
            Descargarbtn.Click += Descargarbtn_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1242, 849);
            Controls.Add(Descargarbtn);
            Controls.Add(verArchivobtn);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(lblmail);
            Controls.Add(lblnombre);
            Controls.Add(lblTipoCuenta);
            Controls.Add(pictureBox6);
            Controls.Add(CerrarSesionBTN);
            Controls.Add(SubirArchivoBTN);
            Controls.Add(label7);
            Controls.Add(Buscartxt);
            Controls.Add(Buscarbtn);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            MouseDown += Inicio_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button Buscarbtn;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private TextBox Buscartxt;
        private Label label7;
        private Button SubirArchivoBTN;
        private Button CerrarSesionBTN;
        private Label label8;
        private PictureBox pictureBox6;
        private Label lblTipoCuenta;
        private Label lblnombre;
        private Label lblmail;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private Button verArchivobtn;
        private Button Descargarbtn;
    }
}