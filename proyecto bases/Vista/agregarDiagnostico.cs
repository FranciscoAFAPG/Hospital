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
    public partial class agregarDiagnostico : Form
    {
        public agregarDiagnostico()
        {
            InitializeComponent();
        }
        private string observaciones;
        private int enfermedad;
        private int lic_medico;
        private int id_medico;
        private int id_paciente;
        private string nombreM;
        private string nombreP;
        private void limpiar()
        {
            txtNombreP.Text = "";
            txtIdentificacionP.Text = "";
            txtIdentificacionM.Text = "";
            txtNombreM.Text = "";
            txtNombreMedico.Text = "";
            txtObservaciones.Text = "";
            txtNombrePaciente.Text = "";
            btnAgregar.Visible = false;
            lblenfermedad.Visible = false;
            cbxEnfermedad.Visible = false;
            lblMedicos.Visible = true;
            lblPacientes.Visible = true;
            lbltxtmedico.Visible = true;
            lbltxtpaciente.Visible = true;
            panelObservaciones.Visible = false;
            btnSeleccionar.Visible = true;
            Tablas.Visible = true;
            txtNombrePaciente.Visible = true;
            txtNombreMedico.Visible = true;
        }
        private void mostrarPanelDos()
        {
            lblenfermedad.Visible = true;
            cbxEnfermedad.Visible = true;
            lblMedicos.Visible = false;
            lblPacientes.Visible = false;
            lbltxtmedico.Visible = false;
            lbltxtpaciente.Visible = false;
            panelObservaciones.Visible = true;
            Tablas.Visible = false;
            txtNombreMedico.Visible = false;
            txtNombrePaciente.Visible = false;
            btnAgregar.Visible = true;
            btnSeleccionar.Visible = false;
            txtNombreP.Visible = true;
            txtNombreM.Visible = true;
            txtIdentificacionP.Visible = true;
            txtIdentificacionM.Visible = true;
        }
        private void ocultarColumnas()
        {
            tablaMedico.Columns[2].Visible = false;
            tablaMedico.Columns[4].Visible = false;
            tablaMedico.Columns[5].Visible = false;
            tablaMedico.Columns[6].Visible = false;
            tablaMedico.Columns[7].Visible = false;
        }
        private void ocultarColumnasPaciente()
        {
            tablaPaciente.Columns[3].Visible = false;
            tablaPaciente.Columns[4].Visible = false;
            tablaPaciente.Columns[5].Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sustitucionesEmpleados_Load(object sender, EventArgs e)
        {
            mostrarEnfermedad();
            MostrarMedico();
            mostrarPaciente();
            limpiar();
        }
        private void buscarMedico()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.buscarMedicoHorario(ref dt, txtNombreMedico.Text);
            tablaMedico.DataSource = dt;
            ocultarColumnas();
        }
        private void MostrarMedico()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarMedicos(ref dt);
            tablaMedico.DataSource = dt;
            ocultarColumnas();
        }
        private void buscarPaciente()
        {
            DataTable dt = new DataTable();
            DPacientes funcion = new DPacientes();
            funcion.buscarDatosPaciente(ref dt, txtNombrePaciente.Text);
            tablaPaciente.DataSource = dt;
            ocultarColumnasPaciente();
        }
        private void mostrarPaciente()
        {
            DataTable dt = new DataTable();
            DPacientes funcion = new DPacientes();
            funcion.mostrarDatosPaciente(ref dt);
            tablaPaciente.DataSource = dt;
            ocultarColumnasPaciente();
        }
        private void insertarDiagnostico()
        {
            Diagnostico parametros = new Diagnostico();
            Medico parametrosM = new Medico();
            DPacientes funcion = new DPacientes();
            parametrosM.Lic_medica = lic_medico;
            parametros.Id_paciente = id_paciente;
            parametros.Observaciones= observaciones;
            parametros.Id_enfermedad = enfermedad;
            if (funcion.insertarDiagnostico(parametros, parametrosM) == true)
            {
                MessageBox.Show("Diagnostico insertado con exito...", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpiar();
            }
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacionP.Text != "" && txtNombreP.Text != "" && txtIdentificacionM.Text != "" && txtNombreM.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea Agregar el Diagnostico?", "Agregar Diagnostico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (txtObservaciones.Text != "")
                    {
                        if (cbxEnfermedad.Text != "")
                        {
                            enfermedad = Convert.ToInt32(cbxEnfermedad.SelectedValue);
                            observaciones = txtObservaciones.Text;
                            insertarDiagnostico();
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar la enfermedad del Diagnostico...", "Agregar Diagnostico", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar las observaciones del Diagnostico...", "Agregar Diagnostico", MessageBoxButtons.OK);
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Medico y Paciente...", "Asignar Horario", MessageBoxButtons.OK);
            }         
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacionP.Text != "" && txtNombreP.Text != "" && txtIdentificacionM.Text != "" && txtNombreM.Text != "")
            {
                DialogResult result = MessageBox.Show("Continuar con el Medico y Paciente Seleccionado?", "Agregar Diagnostico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    mostrarPanelDos();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Medico y Paciente...", "Agregar Diagnostico", MessageBoxButtons.OK);
            }
        }

        private void txtNombreMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreMedico.Text != "")
            {
                buscarMedico();
            }
            else
            {
                MostrarMedico();
            }
        }

        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {
            if (txtNombrePaciente.Text != "")
            {
                buscarPaciente();
            }
            else
            {
                mostrarPaciente();
            }
        }

        private void tablaMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaMedico.Columns["SelectMedico"].Index)
            {
                txtIdentificacionM.Text = "ID: " + Convert.ToString(tablaMedico.SelectedCells[1].Value);
                txtNombreM.Text = "Nombre: " + Convert.ToString(tablaMedico.SelectedCells[3].Value);
                lic_medico = Convert.ToInt32(tablaMedico.SelectedCells[2].Value);
                id_medico = Convert.ToInt32(tablaMedico.SelectedCells[1].Value);
                nombreM = tablaMedico.SelectedCells[3].Value.ToString();
            }
        }

        private void tablaPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaPaciente.Columns["Select"].Index)
            {
                txtIdentificacionP.Text = "ID: " + Convert.ToString(tablaPaciente.SelectedCells[1].Value);
                txtNombreP.Text = "Nombre: " + Convert.ToString(tablaPaciente.SelectedCells[2].Value);
                id_paciente = Convert.ToInt32(tablaPaciente.SelectedCells[1].Value);
                nombreP = tablaPaciente.SelectedCells[3].Value.ToString();
            }
        }

        private void cbxEnfermedad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
