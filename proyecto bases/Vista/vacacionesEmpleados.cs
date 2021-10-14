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
    public partial class vacacionesEmpleados : Form
    {
        public vacacionesEmpleados()
        {
            InitializeComponent();
        }
        private void mostrarCargo()
        {
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.mostrarCargo(ref dt);
            cbxCargo.DataSource = dt;
            cbxCargo.ValueMember = "id_cargo";
            cbxCargo.DisplayMember = "nombre_cargo";
        }
        private void buscarVacaciones()
        {
            int cargo;
            DateTime FechaInicio;
            DateTime FechaFin;
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            FechaInicio = Convert.ToDateTime(dateFechaInicio.Value.ToShortDateString());
            FechaFin = Convert.ToDateTime(dateFechaFin.Value.ToShortDateString());
            cargo = Convert.ToInt32(cbxCargo.SelectedValue);
            funcion.buscarVacaciones(ref dt, FechaInicio,FechaFin,cargo);
            tablaVacaciones.DataSource = dt;
        }
        private void buscarVacacionesEmpleado()
        {
            string nombre;
            DateTime FechaInicio;
            DateTime FechaFin;
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            FechaInicio = Convert.ToDateTime(dateFechaInicio.Value.ToShortDateString());
            FechaFin = Convert.ToDateTime(dateFechaFin.Value.ToShortDateString());
            nombre = txt_nombre_medico.Text;
            funcion.buscarVacacionesEmpleado(ref dt, FechaInicio, FechaFin, nombre);
            tablaVacaciones.DataSource = dt;
        }
        private void mostrarVacaciones()
        {
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.mostrarVacaciones(ref dt);
            tablaVacaciones.DataSource = dt;
        }
        private void eliminarVacacion()
        {
            Vacacion parametros = new Vacacion();
            Dempleados funcion = new Dempleados();
            parametros.FechaInicio = Convert.ToDateTime(tablaVacaciones.SelectedCells[1].Value);
            parametros.FechaFin = Convert.ToDateTime(tablaVacaciones.SelectedCells[2].Value);
            parametros.Nombre = Convert.ToString(tablaVacaciones.SelectedCells[3].Value);
            if (funcion.eliminarVacacion(parametros) == true)
            {
                MessageBox.Show("Registro eliminado con exito...", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                mostrarVacaciones();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void vacacionesEmpleados_Load(object sender, EventArgs e)
        {
            mostrarCargo();
            mostrarVacaciones();
        }

        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCargo.Text == "Seleccione...")
            {
                mostrarCargo();
            }
        }
        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (txt_nombre_medico.Text != "")
            {
                buscarVacacionesEmpleado();
            }
            else if (txt_nombre_medico.Text == "")
            {
                mostrarVacaciones();
            }
        }

        private void btnBuscarCargo_Click(object sender, EventArgs e)
        {
            if (cbxCargo.ValueMember != "")
            {
                if (Convert.ToInt32(cbxCargo.SelectedValue) != 1)
                    buscarVacaciones();              
            }
            if(Convert.ToInt32(cbxCargo.SelectedValue) == 1)
            {
                mostrarVacaciones();
            }
        }

        private void mostrarTodo_Click(object sender, EventArgs e)
        {
            mostrarVacaciones();
        }

        private void tablaVacaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaVacaciones.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea eliminar el registro de vacaciones seleccionado?", "Eliminar Vacaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminarVacacion();
                }
                if (result == DialogResult.Cancel)
                {
                    mostrarVacaciones();
                }
            }
        }

        private void txt_nombre_medico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
