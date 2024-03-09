using System.Drawing;
using System.Windows.Forms;

namespace Vista

{
    partial class AdministrarUsuarios
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
            button2 = new Button();
            Eliminar = new Button();
            Editar = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            emailtxt = new TextBox();
            usuariotxt = new TextBox();
            nombretxt = new TextBox();
            apellidotxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            dgv = new DataGridView();
            label2 = new Label();
            telefonotxt = new TextBox();
            label3 = new Label();
            contraseñatxt = new TextBox();
            label4 = new Label();
            permisostxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(50, 50, 50);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(746, 366);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(119, 66);
            button2.TabIndex = 62;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(50, 50, 50);
            Eliminar.FlatStyle = FlatStyle.Popup;
            Eliminar.ForeColor = Color.White;
            Eliminar.Location = new Point(820, 200);
            Eliminar.Margin = new Padding(4, 3, 4, 3);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(119, 66);
            Eliminar.TabIndex = 63;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Editar
            // 
            Editar.BackColor = Color.FromArgb(50, 50, 50);
            Editar.FlatStyle = FlatStyle.Popup;
            Editar.ForeColor = Color.White;
            Editar.Location = new Point(660, 200);
            Editar.Margin = new Padding(4, 3, 4, 3);
            Editar.Name = "Editar";
            Editar.Size = new Size(119, 66);
            Editar.TabIndex = 61;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1374, 134);
            panel1.TabIndex = 59;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pictureBox1_Image;
            pictureBox2.Location = new Point(-14, -107);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(314, 328);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(355, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(514, 46);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRAR USUARIOS";
            label1.Click += label1_Click;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.FromArgb(50, 50, 50);
            emailtxt.BorderStyle = BorderStyle.FixedSingle;
            emailtxt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.ForeColor = Color.White;
            emailtxt.Location = new Point(1000, 345);
            emailtxt.Margin = new Padding(4, 3, 4, 3);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(329, 24);
            emailtxt.TabIndex = 73;
            // 
            // usuariotxt
            // 
            usuariotxt.BackColor = Color.FromArgb(50, 50, 50);
            usuariotxt.BorderStyle = BorderStyle.FixedSingle;
            usuariotxt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            usuariotxt.ForeColor = Color.White;
            usuariotxt.Location = new Point(1000, 174);
            usuariotxt.Margin = new Padding(4, 3, 4, 3);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(329, 24);
            usuariotxt.TabIndex = 66;
            // 
            // nombretxt
            // 
            nombretxt.BackColor = Color.FromArgb(50, 50, 50);
            nombretxt.BorderStyle = BorderStyle.FixedSingle;
            nombretxt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nombretxt.ForeColor = Color.White;
            nombretxt.Location = new Point(1000, 231);
            nombretxt.Margin = new Padding(4, 3, 4, 3);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(329, 24);
            nombretxt.TabIndex = 71;
            // 
            // apellidotxt
            // 
            apellidotxt.BackColor = Color.FromArgb(50, 50, 50);
            apellidotxt.BorderStyle = BorderStyle.FixedSingle;
            apellidotxt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            apellidotxt.ForeColor = Color.White;
            apellidotxt.Location = new Point(1000, 288);
            apellidotxt.Margin = new Padding(4, 3, 4, 3);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(329, 24);
            apellidotxt.TabIndex = 72;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1000, 149);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 17);
            label7.TabIndex = 67;
            label7.Text = "Usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1000, 206);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 17);
            label8.TabIndex = 68;
            label8.Text = "Nombre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1000, 263);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 69;
            label9.Text = "Apellido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(1000, 320);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 17);
            label10.TabIndex = 70;
            label10.Text = "Email";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 50);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1113, 566);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(102, 37);
            button1.TabIndex = 74;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 140);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(606, 372);
            dgv.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1000, 377);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 70;
            label2.Text = "Telefono";
            // 
            // telefonotxt
            // 
            telefonotxt.BackColor = Color.FromArgb(50, 50, 50);
            telefonotxt.BorderStyle = BorderStyle.FixedSingle;
            telefonotxt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            telefonotxt.ForeColor = Color.White;
            telefonotxt.Location = new Point(1000, 402);
            telefonotxt.Margin = new Padding(4, 3, 4, 3);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(329, 24);
            telefonotxt.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1000, 434);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 70;
            label3.Text = "Contraseña";
            // 
            // contraseñatxt
            // 
            contraseñatxt.BackColor = Color.FromArgb(50, 50, 50);
            contraseñatxt.BorderStyle = BorderStyle.FixedSingle;
            contraseñatxt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            contraseñatxt.ForeColor = Color.White;
            contraseñatxt.Location = new Point(1000, 459);
            contraseñatxt.Margin = new Padding(4, 3, 4, 3);
            contraseñatxt.Name = "contraseñatxt";
            contraseñatxt.Size = new Size(329, 24);
            contraseñatxt.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1000, 491);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 70;
            label4.Text = "Permisos";
            // 
            // permisostxt
            // 
            permisostxt.BackColor = Color.FromArgb(50, 50, 50);
            permisostxt.BorderStyle = BorderStyle.FixedSingle;
            permisostxt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            permisostxt.ForeColor = Color.White;
            permisostxt.Location = new Point(1000, 516);
            permisostxt.Margin = new Padding(4, 3, 4, 3);
            permisostxt.Name = "permisostxt";
            permisostxt.Size = new Size(329, 24);
            permisostxt.TabIndex = 73;
            // 
            // AdministrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1371, 628);
            Controls.Add(dgv);
            Controls.Add(button1);
            Controls.Add(permisostxt);
            Controls.Add(contraseñatxt);
            Controls.Add(telefonotxt);
            Controls.Add(emailtxt);
            Controls.Add(usuariotxt);
            Controls.Add(nombretxt);
            Controls.Add(apellidotxt);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(Eliminar);
            Controls.Add(Editar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdministrarUsuarios";
            Text = "AdministrarUsuarios";
            Load += AdministrarUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button Eliminar;
        private Button Editar;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox emailtxt;
        private TextBox usuariotxt;
        private TextBox nombretxt;
        private TextBox apellidotxt;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private DataGridView dgv;
        private Label label2;
        private TextBox telefonotxt;
        private Label label3;
        private TextBox contraseñatxt;
        private Label label4;
        private TextBox permisostxt;
    }
}