using Controladora;
using iText.StyledXmlParser.Node;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Formularios
{
    public partial class AdministrarGrupos : Form
    {
        ContextoGrupos contextoGrupos = new ContextoGrupos();
        public AdministrarGrupos()
        {
            InitializeComponent();
        }
        int id;
        int usuarios;
        int archivos ;
        int materias;
        int carreras;
        int baseDatos;
        int reportesAuditoria;
        int reportesArchivos;
        int grupo;
        private void AdministrarGrupos_Load(object sender, EventArgs e)
        {
            this.Width = 690;
            this.Height = 563;
            dgv.DataSource = contextoGrupos.ObtenerAdmins();
            dgv.Enabled = true;
        }

        private void Editarbtn_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                if(dgv.CurrentRow.Cells[1].Value.ToString() == "SuperAdmin")
                {
                    MessageBox.Show("No se pueden editar los permisos del SuperAdmin");
                }
                else
                {
                    dgv.Enabled = false;
                    id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    this.Width = 1050;
                    label2.Text = "Actualmente editando los permisos del usuario: " + dgv.CurrentRow.Cells[1].Value.ToString();
                }
            }
        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            if (AdministrarUsuarioschk.Checked)
            {
                usuarios = 1;
            }
            else
            {
                if (AdministrarUsuarioschk.Checked == false)
                {
                    usuarios = 0;
                }
            }
            if(AdministrarArchivoschk.Checked)
            {
                archivos = 1;
            }
            else
            {
                if (AdministrarArchivoschk.Checked == false)
                {
                    archivos = 0;
                }
            }
            if (AdministrarMateriaschk.Checked)
            {
                materias = 1;
            }
            else
            {
                if (AdministrarMateriaschk.Checked == false)
                {
                    materias = 0;
                }
            }
            if (AdministrarCarreraschk.Checked)
            {
                carreras = 1;
            }
            else
            {
                if (AdministrarCarreraschk.Checked == false)
                {
                    carreras = 0;
                }
            }
            if (AdministrarDBchk.Checked)
            {
                baseDatos = 1;
            }
            else
            {
                if (AdministrarDBchk.Checked == false)
                {
                    baseDatos = 0;
                }
            }
            if (AdministrarReportesAuditoriachk.Checked)
            {
                reportesAuditoria = 1;
            }
            else
            {
                if (AdministrarReportesAuditoriachk.Checked == false)
                {
                    reportesAuditoria = 0;
                }
            }
            if (AdministrarReportesArchivoschk.Checked)
            {
                reportesArchivos = 1;
            }
            else
            {
                if (AdministrarReportesArchivoschk.Checked == false)
                {
                    reportesArchivos = 0;
                }
            }
            if (AdministrarGruposchk.Checked)
            {
                grupo = 1;
            }
            else
            {
                if (AdministrarGruposchk.Checked == false)
                {
                    grupo = 0;
                }
            }
            MessageBox.Show(contextoGrupos.ModificarGrupo(id, usuarios, archivos, materias, carreras, baseDatos, reportesAuditoria, reportesArchivos, grupo));
            this.Width = 690;
            dgv.Enabled = true;
        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            dgv.Enabled = true;
            this.Width = 690;
        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdministrador vistaAdministrador = new VistaAdministrador();
            vistaAdministrador.Show();
        }
    }
}
