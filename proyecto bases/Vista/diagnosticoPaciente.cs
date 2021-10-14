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
    public partial class diagnosticoPaciente : Form
    {
        public diagnosticoPaciente()
        {
            InitializeComponent();
        }
        private void mostrarEnfermedad()
        {
            DataTable dt = new DataTable();
            DPacientes funcion = new DPacientes();
            funcion.mostrarEnfermedad(ref dt);
            cbxEnfermedad.DataSource = dt;
            cbxEnfermedad.ValueMember = "id_enfermedad";
            cbxEnfermedad.DisplayMember = "nombre_enf";
            cbxEnfermedad.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void buscarPaciente()
        {
            int enfermedad;
            DataTable dt = new DataTable();
            DPacientes funcion = new DPacientes();
            enfermedad = Convert.ToInt32(cbxEnfermedad.SelectedValue);
            funcion.buscarPaciente(ref dt, enfermedad);
            tablaDiagnostico.DataSource = dt;
        }
        private void mostrarDatosPaciente()
        {
            DataTable dt = new DataTable();
            DPacientes funcion = new DPacientes();
            funcion.mostrarDatosPaciente(ref dt);
            tablaDiagnostico.DataSource = dt;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void diagnosticoPaciente_Load(object sender, EventArgs e)
        {
            mostrarEnfermedad();
        }

        private void cbxEnfermedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEnfermedad.ValueMember != "")
            {
                if (cbxEnfermedad.ValueMember != "Seleccione...")
                    buscarPaciente();
            }
            if (cbxEnfermedad.Text == "Seleccione...")
            {
                mostrarDatosPaciente();
            }
        }
    }
}
