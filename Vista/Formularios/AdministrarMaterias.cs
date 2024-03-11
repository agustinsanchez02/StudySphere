﻿using Controladora;
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
    public partial class AdministrarMaterias : Form
    {
        Controladora.ContextoMateria contextoMateria = new Controladora.ContextoMateria();
        string accion = "";
        public AdministrarMaterias()
        {
            InitializeComponent();
        }

        private void AdministrarMaterias_Load(object sender, EventArgs e)
        {
            this.Width = 673;
            this.Height = 450;
            dgv.DataSource = contextoMateria.ListarMaterias();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Width = 1003;
            accion = "agregar";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (accion == "agregar")
            {
                if (nombretxt.Text == "")
                {
                    MessageBox.Show("El campo Nombre esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (descripciontxt.Text == "")
                    {
                        MessageBox.Show("El campo Descripcion esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        contextoMateria.AgregarMateria(nombretxt.Text, descripciontxt.Text);
                        MessageBox.Show("Materia agregada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nombretxt.Text = "";
                        descripciontxt.Text = "";
                        AdministrarMaterias_Load(sender, e);
                    }
                }
            }
            if (accion == "editar")
            {
                if (dgv.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna Materia seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    contextoMateria.ModificarMateria(nombretxt.Text, descripciontxt.Text, dgv.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Materia editada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nombretxt.Text = "";
                    descripciontxt.Text = "";
                    AdministrarMaterias_Load(sender, e);
                }
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna carrera seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la carrera seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    contextoMateria.EliminarMateria(dgv.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Carrera eliminada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdministrarMaterias_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void Editarbtn_Click(object sender, EventArgs e)
        {
            CargarDatos();
            this.Width = 1003;
            accion = "editar";
        }
        public void CargarDatos()
        {
            if (dgv.SelectedRows.Count == 1)
            {
                nombretxt.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                descripciontxt.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("No hay ninguna carrera seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdministrador vistaAdministrador = new VistaAdministrador();
            vistaAdministrador.Show();
        }
    }
}