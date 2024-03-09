using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class MetodoDePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoDePago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Visa = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Mastercard = new Bunifu.Framework.UI.BunifuCheckbox();
            this.American_Express = new Bunifu.Framework.UI.BunifuCheckbox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titular = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.numerotarjeta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.mes = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.año = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cvv = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.Aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 136);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Cancelar
            // 
            this.Cancelar.ActiveBorderThickness = 1;
            this.Cancelar.ActiveCornerRadius = 20;
            this.Cancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.Cancelar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelar.BackgroundImage")));
            this.Cancelar.ButtonText = "Cancelar";
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.Cancelar.IdleBorderThickness = 1;
            this.Cancelar.IdleCornerRadius = 30;
            this.Cancelar.IdleFillColor = System.Drawing.Color.Transparent;
            this.Cancelar.IdleForecolor = System.Drawing.Color.White;
            this.Cancelar.IdleLineColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(794, 87);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(125, 44);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Confirmación";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 30;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.Location = new System.Drawing.Point(428, 87);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(152, 44);
            this.bunifuThinButton22.TabIndex = 2;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Pago";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 30;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(246, 87);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(152, 44);
            this.bunifuThinButton21.TabIndex = 1;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Bk", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(706, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total: ARS 1.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Bk", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Checkout ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.pictureBox1_Image;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(37, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metodo de pago";
            // 
            // Visa
            // 
            this.Visa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Visa.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Visa.Checked = true;
            this.Visa.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Visa.ForeColor = System.Drawing.Color.White;
            this.Visa.Location = new System.Drawing.Point(41, 205);
            this.Visa.Name = "Visa";
            this.Visa.Size = new System.Drawing.Size(20, 20);
            this.Visa.TabIndex = 4;
            this.Visa.OnChange += new System.EventHandler(this.Visa_OnChange);
            // 
            // Mastercard
            // 
            this.Mastercard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Mastercard.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Mastercard.Checked = true;
            this.Mastercard.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Mastercard.ForeColor = System.Drawing.Color.White;
            this.Mastercard.Location = new System.Drawing.Point(166, 205);
            this.Mastercard.Name = "Mastercard";
            this.Mastercard.Size = new System.Drawing.Size(20, 20);
            this.Mastercard.TabIndex = 5;
            this.Mastercard.OnChange += new System.EventHandler(this.Mastercard_OnChange);
            // 
            // American_Express
            // 
            this.American_Express.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.American_Express.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.American_Express.Checked = true;
            this.American_Express.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.American_Express.ForeColor = System.Drawing.Color.White;
            this.American_Express.Location = new System.Drawing.Point(292, 205);
            this.American_Express.Name = "American_Express";
            this.American_Express.Size = new System.Drawing.Size(20, 20);
            this.American_Express.TabIndex = 6;
            this.American_Express.OnChange += new System.EventHandler(this.American_Express_OnChange);
            // 
            // imagen
            // 
            this.imagen.Image = global::Vista.Properties.Resources.American_Express_Logo;
            this.imagen.Location = new System.Drawing.Point(316, 189);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(86, 54);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 4;
            this.imagen.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vista.Properties.Resources.MasterCard_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(191, 195);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.VISA_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(66, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(40, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Titular de la tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(645, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de vencimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(40, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Numero de la tarjeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(645, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Codigo de seguridad";
            // 
            // titular
            // 
            this.titular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.titular.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.titular.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.titular.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.titular.BorderThickness = 1;
            this.titular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titular.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.titular.ForeColor = System.Drawing.Color.White;
            this.titular.isPassword = false;
            this.titular.Location = new System.Drawing.Point(44, 350);
            this.titular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titular.Name = "titular";
            this.titular.Size = new System.Drawing.Size(416, 44);
            this.titular.TabIndex = 8;
            this.titular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.titular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.titular_KeyPress);
            // 
            // numerotarjeta
            // 
            this.numerotarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numerotarjeta.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.numerotarjeta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.numerotarjeta.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.numerotarjeta.BorderThickness = 1;
            this.numerotarjeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numerotarjeta.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.numerotarjeta.ForeColor = System.Drawing.Color.White;
            this.numerotarjeta.isPassword = false;
            this.numerotarjeta.Location = new System.Drawing.Point(44, 476);
            this.numerotarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numerotarjeta.Name = "numerotarjeta";
            this.numerotarjeta.Size = new System.Drawing.Size(416, 44);
            this.numerotarjeta.TabIndex = 11;
            this.numerotarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numerotarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerotarjeta_KeyPress);
            // 
            // mes
            // 
            this.mes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mes.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.mes.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.mes.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.mes.BorderThickness = 1;
            this.mes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mes.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.mes.ForeColor = System.Drawing.Color.White;
            this.mes.isPassword = false;
            this.mes.Location = new System.Drawing.Point(649, 350);
            this.mes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(54, 44);
            this.mes.TabIndex = 9;
            this.mes.Text = "MM";
            this.mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mes.Enter += new System.EventHandler(this.mes_Enter);
            this.mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mes_KeyPress);
            this.mes.Leave += new System.EventHandler(this.mes_Leave);
            // 
            // año
            // 
            this.año.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.año.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.año.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.año.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.año.BorderThickness = 1;
            this.año.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.año.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.año.ForeColor = System.Drawing.Color.White;
            this.año.isPassword = false;
            this.año.Location = new System.Drawing.Point(723, 350);
            this.año.Margin = new System.Windows.Forms.Padding(5);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(96, 44);
            this.año.TabIndex = 10;
            this.año.Text = "AAAA";
            this.año.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.año.Enter += new System.EventHandler(this.año_Enter);
            this.año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.año_KeyPress);
            this.año.Leave += new System.EventHandler(this.año_Leave);
            // 
            // cvv
            // 
            this.cvv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cvv.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.cvv.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cvv.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.cvv.BorderThickness = 1;
            this.cvv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cvv.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cvv.ForeColor = System.Drawing.Color.White;
            this.cvv.isPassword = false;
            this.cvv.Location = new System.Drawing.Point(649, 476);
            this.cvv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(97, 44);
            this.cvv.TabIndex = 12;
            this.cvv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cvv_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(645, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tipo de suscripcion\r\n";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "Elija una opción...",
        "Mensual",
        "Anual"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(649, 195);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(170, 30);
            this.bunifuDropdown1.TabIndex = 7;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // Aceptar
            // 
            this.Aceptar.ActiveBorderThickness = 1;
            this.Aceptar.ActiveCornerRadius = 20;
            this.Aceptar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Aceptar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Aceptar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aceptar.BackgroundImage")));
            this.Aceptar.ButtonText = "Confirmar";
            this.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.Aceptar.IdleBorderThickness = 1;
            this.Aceptar.IdleCornerRadius = 20;
            this.Aceptar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Aceptar.IdleForecolor = System.Drawing.Color.White;
            this.Aceptar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Aceptar.Location = new System.Drawing.Point(660, 584);
            this.Aceptar.Margin = new System.Windows.Forms.Padding(5);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(149, 38);
            this.Aceptar.TabIndex = 13;
            this.Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // MetodoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(919, 649);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.año);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.numerotarjeta);
            this.Controls.Add(this.titular);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.American_Express);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Mastercard);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Visa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetodoDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MetodoDePago_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MetodoDePago_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox Visa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCheckbox Mastercard;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCheckbox American_Express;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox titular;
        private Bunifu.Framework.UI.BunifuMetroTextbox numerotarjeta;
        private Bunifu.Framework.UI.BunifuMetroTextbox mes;
        private Bunifu.Framework.UI.BunifuMetroTextbox año;
        private Bunifu.Framework.UI.BunifuMetroTextbox cvv;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuThinButton2 Aceptar;
    }
}