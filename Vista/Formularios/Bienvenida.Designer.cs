using System.Drawing;
using System.Windows.Forms;

namespace Vista.Formularios
{
    partial class Bienvenida
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 123);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pictureBox1_Image;
            pictureBox2.Location = new Point(13, -97);
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
            label1.Location = new Point(632, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alumno;
            pictureBox1.Location = new Point(1, 119);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(721, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.Font = new Font("Microsoft Sans Serif", 50F, FontStyle.Bold, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.White;
            circularProgressBar1.InnerColor = Color.Gray;
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(643, 260);
            circularProgressBar1.Margin = new Padding(4, 3, 4, 3);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.FromArgb(30, 30, 30);
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 26;
            circularProgressBar1.ProgressColor = Color.FromArgb(113, 96, 232);
            circularProgressBar1.ProgressWidth = 25;
            circularProgressBar1.SecondaryFont = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(264, 248);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.Style = ProgressBarStyle.Marquee;
            circularProgressBar1.SubscriptColor = Color.White;
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.White;
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "%";
            circularProgressBar1.TabIndex = 3;
            circularProgressBar1.Text = "0";
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar1.Value = 68;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1148, 532);
            Controls.Add(circularProgressBar1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            Load += Bienvenida_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}