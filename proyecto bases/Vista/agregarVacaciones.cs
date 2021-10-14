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
    public partial class agregarVacaciones : Form
    {
        public agregarVacaciones()
        {
            InitializeComponent();
        }
        private int id_empleado;
        private string nombre;
        private void mostrarCargo()
        {
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.mostrarCargo(ref dt);
            cbxCargo.DataSource = dt;
            cbxCargo.ValueMember = "id_cargo";
            cbxCargo.DisplayMember = "nombre_cargo";
        }
        
        private void mostrarEmpleados()
        {
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.mostrarTodoPersonal(ref dt);
            tablaAgregarVacaciones.DataSource = dt;
        }
        private void buscarEmpleadoCargo()
        {
            int cargo;
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            cargo = Convert.ToInt32(cbxCargo.SelectedValue);
            funcion.buscarEmpleadoCargo(ref dt, cargo);
            tablaAgregarVacaciones.DataSource = dt;
        }
        private void buscarEmpleado()
        {
            string nombre;
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            nombre = txt_nombre.Text;
            funcion.buscarEmpleado(ref dt, nombre);
            tablaAgregarVacaciones.DataSource = dt;
        }
        private void insertarVacaciones()
        {
            txtIdentificacion.Text = "ID: " + Convert.ToString(id_empleado);
            txtNombreEmpleado.Text = "Nombre: " + nombre;
            Vacacion parametros = new Vacacion();
            Dempleados funcion = new Dempleados();
            parametros.Identificacion = id_empleado;
            parametros.FechaInicio= Convert.ToDateTime(dateFechaInicio.Value.ToShortDateString());
            parametros.FechaFin= Convert.ToDateTime(dateFechaFin.Value.ToShortDateString());
            if(funcion.agregarVacaciones(parametros)==true)
            {
                MessageBox.Show("Vacaciones insertadas con exito...", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Limpiar();
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
            mostrarEmpleados();
            txtIdentificacion.Visible = false;
            txtNombreEmpleado.Visible = false;
            btnAgregar.Visible = false;
        }
        private void Limpiar()
        {
            txtNombreEmpleado.Text = "";
            txtIdentificacion.Text = "";
            txtIdentificacion.Visible = false;
            txtNombreEmpleado.Visible = false;
            btnAgregar.Visible = false;
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
            if (txt_nombre.Text != "")
            {
                buscarEmpleado();
            }else if (txt_nombre.Text== "")
            {
                mostrarEmpleados();
            }
        }

        private void btnBuscarCargo_Click(object sender, EventArgs e)
        {
            if (cbxCargo.ValueMember != "")
            {
                if (Convert.ToInt32(cbxCargo.SelectedValue) != 1)
                    buscarEmpleadoCargo();
            }
            if (Convert.ToInt32(cbxCargo.SelectedValue) == 1)
            {
                mostrarEmpleados();
            }
        }

        private void tablaAgregarVacaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaAgregarVacaciones.Columns["Agregar"].Index)
            {
                DialogResult result = MessageBox.Show("Recuerde Seleccionar Fecha de Inicio y Fin de las Vacaciones...", "Agregar Vacaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    txtIdentificacion.Visible = true;
                    txtNombreEmpleado.Visible = true;
                    btnAgregar.Visible = true;
                    txtIdentificacion.Text = "ID: " + tablaAgregarVacaciones.SelectedCells[1].Value.ToString();
                    txtNombreEmpleado.Text = "Nombre: " + tablaAgregarVacaciones.SelectedCells[2].Value.ToString();
                    id_empleado = Convert.ToInt32(tablaAgregarVacaciones.SelectedCells[1].Value);
                    nombre = tablaAgregarVacaciones.SelectedCells[2].Value.ToString();
                }
                if (result == DialogResult.Cancel)
                {
                    Limpiar();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarVacaciones();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
