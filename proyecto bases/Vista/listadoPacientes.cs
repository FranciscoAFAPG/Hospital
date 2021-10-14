using proyecto_bases.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto_bases
{
    public partial class listadoPacientes : Form
    {
        public listadoPacientes()
        {
            InitializeComponent();
        }
        int especialidad;
        private void buscarMedico()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.buscarMedico(ref dt, txt_medico_atiende.Text);
            tablaListado.DataSource = dt;
        }
        private void buscarPaciente()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.buscarPaciente(ref dt, txtpaciente.Text);
            tablaListado.DataSource = dt;
        }
        private void buscarEspecialidad()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            especialidad = Convert.ToInt32(cbxEspecialidad.SelectedValue);
            funcion.buscarEspecialidad(ref dt, especialidad);
            tablaListado.DataSource = dt;
        }
        private void mostrarListadoMedicoPaciente()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarListadoMedicoPaciente(ref dt);
            tablaListado.DataSource = dt;
        }
        private void mostrarEspecialidad()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarEspecialidad(ref dt);
            cbxEspecialidad.DataSource = dt;
            cbxEspecialidad.ValueMember = "id_especialidad";
            cbxEspecialidad.DisplayMember = "nombre_esp";
            cbxEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void txt_medico_atiende_TextChanged(object sender, EventArgs e)
        {
            buscarMedico();
        }


        private void tablaListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listadoPacientes_Load(object sender, EventArgs e)
        {
            mostrarEspecialidad();
            mostrarListadoMedicoPaciente();
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEspecialidad.ValueMember != "")
            {
                if (cbxEspecialidad.ValueMember != "Seleccione...")
                    buscarEspecialidad();
            }
            if (cbxEspecialidad.Text == "Seleccione...")
            {
                mostrarListadoMedicoPaciente();
            }
        }

        private void txtpaciente_TextChanged(object sender, EventArgs e)
        {
            buscarPaciente();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
