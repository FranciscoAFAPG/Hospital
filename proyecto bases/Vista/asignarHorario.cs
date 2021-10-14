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
    public partial class asignarHorario : Form
    {
        public asignarHorario()
        {
            InitializeComponent();
        }
        private string horaUno;
        private string horaDos;
        private int dia;
        private int lic_medico;
        private int id_medico;
        private string nombre;

        private void buscarMedico()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.buscarMedicoHorario(ref dt, txtNombre.Text);
            tablaEmpleado.DataSource = dt;
            ocultarColumnas();
        }
        private void mostrarHorario()
        {
            dia = Convert.ToInt32(cbxDia.SelectedValue);
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.buscarHorario(ref dt,dia);
            tablaHorario.DataSource = dt;
        }
        private void mostrarDia()
        {
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.buscarDia(ref dt);
            cbxDia.DataSource = dt;
            cbxDia.ValueMember = "id_dia";
            cbxDia.DisplayMember = "Dia";
            cbxDia.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void MostrarMedico()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarMedicos(ref dt);
            tablaEmpleado.DataSource = dt;
            ocultarColumnas();
        }
        private void mostrarHorarioAsignado()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarHorarioAsignado(ref dt,lic_medico);
            tablaHorarioAsignado.DataSource = dt;
        }
        private void insertarHorario()
        {
            DMedicos funcion = new DMedicos();
            if (funcion.insertarHorario(horaUno,horaDos,dia,lic_medico) == true)
            {
                MessageBox.Show("Horario insertado con exito...", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpiar();
                mostrarHorarioAsignado();
            }
        }
        private void eliminarHorario()
        {
            DMedicos funcion = new DMedicos();
            if (funcion.eliminarHorario(lic_medico,dia) == true)
            {
                MessageBox.Show("Registro eliminado con exito...", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                mostrarHorarioAsignado();
            }
        }
        private void limpiar()
        {
            txtHoraFin.Text = "";
            txtHoraInicio.Text = "";
            txtIdentificacion.Text = "";
            txtNombreEmpleado.Text = "";
            btnAgregar.Visible = false;
        }
        private void ocultarColumnas()
        {
            tablaEmpleado.Columns[4].Visible = false;
            tablaEmpleado.Columns[5].Visible = false;
            tablaEmpleado.Columns[6].Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sustitucionesEmpleados_Load(object sender, EventArgs e)
        {
            mostrarDia();
            MostrarMedico();
            limpiar();
        }
        private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDia.ValueMember != "")
            {
                if (cbxDia.ValueMember != "Seleccione...")
                    mostrarHorario();
            }
        }

        private void tablaHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaHorario.Columns["Select"].Index)
            {
                txtHoraInicio.Text = "Hora Inicio: " + Convert.ToString(tablaHorario.SelectedCells[1].Value);
                txtHoraFin.Text = "Hora Fin: " + Convert.ToString(tablaHorario.SelectedCells[2].Value);
                horaUno = Convert.ToString(tablaHorario.SelectedCells[1].Value);
                horaDos = Convert.ToString(tablaHorario.SelectedCells[2].Value);
                txtHoraInicio.Visible = true;
                txtHoraFin.Visible = true;
            }
        }

        private void tablaEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaEmpleado.Columns["SelectMedico"].Index)
            {
                txtIdentificacion.Text = "ID: " + Convert.ToString(tablaEmpleado.SelectedCells[1].Value);
                txtNombreEmpleado.Text = "Nombre: " + Convert.ToString(tablaEmpleado.SelectedCells[3].Value);
                lic_medico = Convert.ToInt32(tablaEmpleado.SelectedCells[2].Value);
                id_medico = Convert.ToInt32(tablaEmpleado.SelectedCells[1].Value.ToString());
                nombre = tablaEmpleado.SelectedCells[3].Value.ToString();
                txtNombreEmpleado.Visible = true;
                txtIdentificacion.Visible = true;
                btnAgregar.Visible = true;
                mostrarHorarioAsignado();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Asignar el Horario Seleccionado?", "Asignar Horario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if(txtHoraInicio.Text != "" && txtHoraFin.Text != "")
                {
                    insertarHorario();
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar Horario a Asignar...", "Asignar Horario", MessageBoxButtons.OK);
                }
            }
            if (result == DialogResult.Cancel)
            {
                limpiar();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtHoraFin.Text = "";
            txtHoraInicio.Text = "";
            txtIdentificacion.Text = "";
            txtNombreEmpleado.Text = "";
            txtNombre.Text = "";
            btnAgregar.Visible = false;
            nombre = "";
            id_medico = 0;
            dia = 0;
            lic_medico = 0;
            horaDos = "";
            horaUno = "";
            id_medico = 0;
        }

        private void tablaHorarioAsignado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaHorarioAsignado.Columns["Eliminar"].Index) { 

            DialogResult result = MessageBox.Show("Desea Eliminar el Horario Seleccionado?", "Asignar Horario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                    eliminarHorario();
            }
            if (result == DialogResult.Cancel)
            {
                mostrarHorarioAsignado();
            }
        }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            buscarMedico();
        }
    }
}
