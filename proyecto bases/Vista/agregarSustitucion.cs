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
    public partial class agregarSustitucion : Form
    {
        public agregarSustitucion()
        {
            InitializeComponent();
        }
        private int lic_medico;
        private int id_medico;
        private string nombre;
        private void mostrarSustituto()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarMedicoSustituto(ref dt);
            tablaAgregarSustituciones.DataSource = dt;
        }
        private void buscarSustituto()
        {
            string nombre;
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            nombre = txtNombre.Text;
            funcion.buscarSustituto(ref dt, nombre);
            tablaAgregarSustituciones.DataSource = dt;
        }
        private void insertarSustitucion()
        {
            txtIdentificacion.Text = "ID: " + Convert.ToString(id_medico);
            txtNombreEmpleado.Text = "Nombre: "+ nombre;
            Sustituciones parametros = new Sustituciones();
            DMedicos funcion = new DMedicos();
            parametros.Licencia = lic_medico;
            parametros.FechaInicio = Convert.ToDateTime(dateFechaInicio.Value.ToShortDateString());
            parametros.FechaFin = Convert.ToDateTime(dateFechaFin.Value.ToShortDateString());
            if (funcion.agregarSustitucion(parametros) == true)
            {
                MessageBox.Show("Sustitucion insertada con exito...", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Limpiar();
            }
        }
        private void Limpiar()
        {
            txtNombreEmpleado.Text = "";
            txtIdentificacion.Text = "";
            txtIdentificacion.Visible = false;
            txtNombreEmpleado.Visible = false;
            btnAgregar.Visible = false;
            btnAgregar.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sustitucionesEmpleados_Load(object sender, EventArgs e)
        {
            mostrarSustituto();
            Limpiar();
        }

        private void btnBuscarSustitucion_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSustitucionesEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                buscarSustituto();
            }
            else if (txtNombre.Text == "")
            {
                mostrarSustituto();
            }
        }
        private void tablaAgregarSustituciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaAgregarSustituciones.Columns["Agregar"].Index)
            {
                DialogResult result = MessageBox.Show("Recuerde Seleccionar Fecha de Inicio y Fin de la Sustitucion...", "Agregar Sustitucion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {

                    txtIdentificacion.Visible = true;
                    txtNombreEmpleado.Visible = true;
                    btnAgregar.Visible = true;
                    txtIdentificacion.Text = "ID: " + tablaAgregarSustituciones.SelectedCells[1].Value.ToString();
                    txtNombreEmpleado.Text = "Nombre: " + tablaAgregarSustituciones.SelectedCells[3].Value.ToString();
                    lic_medico = Convert.ToInt32(tablaAgregarSustituciones.SelectedCells[2].Value);
                    id_medico = Convert.ToInt32(tablaAgregarSustituciones.SelectedCells[1].Value.ToString());
                    nombre = tablaAgregarSustituciones.SelectedCells[3].Value.ToString();
                }
                if (result == DialogResult.Cancel)
                {
                    Limpiar();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarSustitucion();
        }
    }
}
