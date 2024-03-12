namespace Vista.Formularios
{
    partial class AdministrarGrupos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.AdministrarGruposchk = new System.Windows.Forms.CheckBox();
            this.AdministrarReportesArchivoschk = new System.Windows.Forms.CheckBox();
            this.AdministrarReportesAuditoriachk = new System.Windows.Forms.CheckBox();
            this.AdministrarDBchk = new System.Windows.Forms.CheckBox();
            this.AdministrarCarreraschk = new System.Windows.Forms.CheckBox();
            this.AdministrarMateriaschk = new System.Windows.Forms.CheckBox();
            this.AdministrarArchivoschk = new System.Windows.Forms.CheckBox();
            this.AdministrarUsuarioschk = new System.Windows.Forms.CheckBox();
            this.Editarbtn = new System.Windows.Forms.Button();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.Salirbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 102);
            this.panel1.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRAR PERMISOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.pictureBox1_Image;
            this.pictureBox2.Location = new System.Drawing.Point(-42, -144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 440);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(28, 121);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(623, 349);
            this.dgv.TabIndex = 81;
            // 
            // AdministrarGruposchk
            // 
            this.AdministrarGruposchk.AutoSize = true;
            this.AdministrarGruposchk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdministrarGruposchk.Location = new System.Drawing.Point(859, 325);
            this.AdministrarGruposchk.Name = "AdministrarGruposchk";
            this.AdministrarGruposchk.Size = new System.Drawing.Size(114, 17);
            this.AdministrarGruposchk.TabIndex = 82;
            this.AdministrarGruposchk.Text = "Administrar Grupos";
            this.AdministrarGruposchk.UseVisualStyleBackColor = true;
            // 
            // AdministrarReportesArchivoschk
            // 
            this.AdministrarReportesArchivoschk.AutoSize = true;
            this.AdministrarReportesArchivoschk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdministrarReportesArchivoschk.Location = new System.Drawing.Point(859, 276);
            this.AdministrarReportesArchivoschk.Name = "AdministrarReportesArchivoschk";
            this.AdministrarReportesArchivoschk.Size = new System.Drawing.Size(167, 17);
            this.AdministrarReportesArchivoschk.TabIndex = 83;
            this.AdministrarReportesArchivoschk.Text = "Administrar Reportes Archivos";
            this.AdministrarReportesArchivoschk.UseVisualStyleBackColor = true;
            // 
            // AdministrarReportesAuditoriachk
            // 
            this.AdministrarReportesAuditoriachk.AutoSize = true;
            this.AdministrarReportesAuditoriachk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdministrarReportesAuditoriachk.Location = new System.Drawing.Point(859, 227);
            this.AdministrarReportesAuditoriachk.Name = "AdministrarReportesAuditoriachk";
            this.AdministrarReportesAuditoriachk.Size = new System.Drawing.Size(167, 17);
            this.AdministrarReportesAuditoriachk.TabIndex = 84;
            this.AdministrarReportesAuditoriachk.Text = "Administrar Reportes Auditoria";
            this.AdministrarReportesAuditoriachk.UseVisualStyleBackColor = true;
            // 
            // AdministrarDBchk
            // 
            this.AdministrarDBchk.AutoSize = true;
            this.AdministrarDBchk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdministrarDBchk.Location = new System.Drawing.Point(859, 178);
            this.AdministrarDBchk.Name = "AdministrarDBchk";
            this.AdministrarDBchk.Size = new System.Drawing.Size(150, 17);
            this.AdministrarDBchk.TabIndex = 85;
            this.AdministrarDBchk.Text = "Administrar Base de Datos";
            this.AdministrarDBchk.UseVisualStyleBackColor = true;
            // 
            // AdministrarCarreraschk
            // 
            this.AdministrarCarreraschk.AutoSize = true;
            this.AdministrarCarreraschk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdministrarCarreraschk.Location = new System.Drawing.Point(709, 325);
            this.AdministrarCarreraschk.Name = "AdministrarCarreraschk";
            this.AdministrarCarreraschk.Size = new System.Drawing.Size(119, 17);
            this.AdministrarCarreraschk.TabIndex = 86;
            this.AdministrarCarreraschk.Text = "Administrar Carreras";
            this.AdministrarCarreraschk.UseVisualStyleBackColor = true;
            // 
            // AdministrarMateriaschk
            // 
            this.AdministrarMateriaschk.AutoSize = true;
            this.AdministrarMateriaschk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdministrarMateriaschk.Location = new System.Drawing.Point(709, 276);
            this.AdministrarMateriaschk.Name = "AdministrarMateriaschk";
            this.AdministrarMateriaschk.Size = new System.Drawing.Size(120, 17);
            this.AdministrarMateriaschk.TabIndex = 87;
            this.AdministrarMateriaschk.Text = "Administrar Materias";
            this.AdministrarMateriaschk.UseVisualStyleBackColor = true;
            // 
            // AdministrarArchivoschk
            // 
            this.AdministrarArchivoschk.AutoSize = true;
            this.AdministrarArchivoschk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdministrarArchivoschk.Location = new System.Drawing.Point(709, 227);
            this.AdministrarArchivoschk.Name = "AdministrarArchivoschk";
            this.AdministrarArchivoschk.Size = new System.Drawing.Size(121, 17);
            this.AdministrarArchivoschk.TabIndex = 88;
            this.AdministrarArchivoschk.Text = "Administrar Archivos";
            this.AdministrarArchivoschk.UseVisualStyleBackColor = true;
            // 
            // AdministrarUsuarioschk
            // 
            this.AdministrarUsuarioschk.AutoSize = true;
            this.AdministrarUsuarioschk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdministrarUsuarioschk.Location = new System.Drawing.Point(709, 178);
            this.AdministrarUsuarioschk.Name = "AdministrarUsuarioschk";
            this.AdministrarUsuarioschk.Size = new System.Drawing.Size(128, 18);
            this.AdministrarUsuarioschk.TabIndex = 89;
            this.AdministrarUsuarioschk.Text = "Administrar Usuarios";
            this.AdministrarUsuarioschk.UseCompatibleTextRendering = true;
            this.AdministrarUsuarioschk.UseVisualStyleBackColor = true;
            // 
            // Editarbtn
            // 
            this.Editarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Editarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Editarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editarbtn.Location = new System.Drawing.Point(565, 492);
            this.Editarbtn.Name = "Editarbtn";
            this.Editarbtn.Size = new System.Drawing.Size(67, 48);
            this.Editarbtn.TabIndex = 90;
            this.Editarbtn.Text = "Editar permisos";
            this.Editarbtn.UseVisualStyleBackColor = false;
            this.Editarbtn.Click += new System.EventHandler(this.Editarbtn_Click);
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Guardarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guardarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbtn.Location = new System.Drawing.Point(876, 401);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(84, 37);
            this.Guardarbtn.TabIndex = 90;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = false;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(706, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Actualmente editando los permisos del usuario";
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Cancelarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelarbtn.Location = new System.Drawing.Point(731, 401);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(84, 37);
            this.Cancelarbtn.TabIndex = 90;
            this.Cancelarbtn.Text = "Cancelar";
            this.Cancelarbtn.UseVisualStyleBackColor = false;
            this.Cancelarbtn.Click += new System.EventHandler(this.Cancelarbtn_Click);
            // 
            // Salirbtn
            // 
            this.Salirbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Salirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Salirbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salirbtn.Location = new System.Drawing.Point(28, 492);
            this.Salirbtn.Name = "Salirbtn";
            this.Salirbtn.Size = new System.Drawing.Size(64, 48);
            this.Salirbtn.TabIndex = 90;
            this.Salirbtn.Text = "Salir";
            this.Salirbtn.UseVisualStyleBackColor = false;
            this.Salirbtn.Click += new System.EventHandler(this.Salirbtn_Click);
            // 
            // AdministrarGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1046, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Salirbtn);
            this.Controls.Add(this.Cancelarbtn);
            this.Controls.Add(this.Guardarbtn);
            this.Controls.Add(this.Editarbtn);
            this.Controls.Add(this.AdministrarUsuarioschk);
            this.Controls.Add(this.AdministrarArchivoschk);
            this.Controls.Add(this.AdministrarMateriaschk);
            this.Controls.Add(this.AdministrarCarreraschk);
            this.Controls.Add(this.AdministrarDBchk);
            this.Controls.Add(this.AdministrarReportesAuditoriachk);
            this.Controls.Add(this.AdministrarReportesArchivoschk);
            this.Controls.Add(this.AdministrarGruposchk);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarGrupos";
            this.Load += new System.EventHandler(this.AdministrarGrupos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.CheckBox AdministrarGruposchk;
        private System.Windows.Forms.CheckBox AdministrarReportesArchivoschk;
        private System.Windows.Forms.CheckBox AdministrarReportesAuditoriachk;
        private System.Windows.Forms.CheckBox AdministrarDBchk;
        private System.Windows.Forms.CheckBox AdministrarCarreraschk;
        private System.Windows.Forms.CheckBox AdministrarMateriaschk;
        private System.Windows.Forms.CheckBox AdministrarArchivoschk;
        private System.Windows.Forms.CheckBox AdministrarUsuarioschk;
        private System.Windows.Forms.Button Editarbtn;
        private System.Windows.Forms.Button Guardarbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.Button Salirbtn;
    }
}