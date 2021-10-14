using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using proyecto_bases.Logica;

namespace proyecto_bases
{
    public partial class exempleados : Form
    {
        public exempleados()
        {
            InitializeComponent();
        }
        private int id_empleado;
        private string nombre;
        private int cargo;
        private void Limpiar()
        {
            txt_nombre_emp.Text = "";
        }
        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.mostrarExempleado(ref dt);
            tablaExempleado.DataSource = dt;
        }
        private void mostrarCargo()
        {
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.mostrarCargo(ref dt);
            list_cargo.DataSource = dt;
            list_cargo.ValueMember = "id_cargo";
            list_cargo.DisplayMember = "nombre_cargo";
        }
        private void buscarExempleado()
        {
            nombre = txt_nombre_emp.Text;
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.buscarExempleado(ref dt, nombre);
            tablaExempleado.DataSource = dt;
        }
        private void buscarExempleadoCargo()
        {
            cargo = Convert.ToInt32(list_cargo.SelectedValue);
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.buscarExempleadoCargo(ref dt, cargo);
            tablaExempleado.DataSource = dt;
        }
        private void eliminarExempleado()
        {
            id_empleado = Convert.ToInt32(tablaExempleado.SelectedCells[1].Value);
            Exempleado parametros = new Exempleado();
            Dempleados funcion = new Dempleados();
            parametros.Identificacion = id_empleado;
            if (funcion.eliminarExempleado(parametros) == true)
            {
                MostrarPersonal();
            }
        }

        private void tablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaExempleado.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Eliminar el Empleado?", "Editar empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminarExempleado();
                    Limpiar();
                }
            }
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            MostrarPersonal();
            mostrarCargo();
        }
        private void list_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_cargo.ValueMember != "")
            {
                if(list_cargo.ValueMember != "Seleccione...")
                {
                    buscarExempleadoCargo();
                }
            }
            if (list_cargo.Text == "Seleccione...")
            {
                MostrarPersonal();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nombre_emp_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombre_emp.Text != "")
            {
                buscarExempleado();
            }
            if (txt_nombre_emp.Text == "")
            {
                MostrarPersonal();
            }
        }
    }
}
