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
    public partial class disponibilidadMedicos : Form
    {
        public disponibilidadMedicos()
        {
            InitializeComponent();
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
        private void buscarDisponibilidad()
        {
            int especialidad;
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            especialidad = Convert.ToInt32(cbxEspecialidad.SelectedValue);
            funcion.buscarDisponibilidad(ref dt, especialidad);
            tablaDisponibilidad.DataSource = dt;
        }
        private void mostrarDisponible()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarDisponible(ref dt);
            tablaDisponibilidad.DataSource = dt;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void disponibilidadMedicos_Load(object sender, EventArgs e)
        {
            mostrarEspecialidad();
            mostrarDisponible();
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEspecialidad.ValueMember != "")
            {
                if (cbxEspecialidad.ValueMember != "Seleccione...")
                    buscarDisponibilidad();
            }
            if (cbxEspecialidad.Text == "Seleccione...")
            {
                mostrarDisponible();
            }
        }
    }
}
