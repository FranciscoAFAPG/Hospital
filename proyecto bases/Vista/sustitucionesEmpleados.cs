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
    public partial class sustitucionesEmpleados : Form
    {
        public sustitucionesEmpleados()
        {
            InitializeComponent();
        }
        private void buscarSustituciones()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            Sustituciones parametros = new Sustituciones();
            parametros.FechaInicio = Convert.ToDateTime(dateFechaInicio.Value.ToShortDateString());
            parametros.FechaFin = Convert.ToDateTime(dateFechaFin.Value.ToShortDateString());
            funcion.buscarSustituciones(ref dt, parametros);
            tablaSustituciones.DataSource = dt;
        }
        private void buscarSustitucionesEmpleado()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            Sustituciones parametros = new Sustituciones();
            parametros.FechaInicio = Convert.ToDateTime(dateFechaInicio.Value.ToShortDateString());
            parametros.FechaFin = Convert.ToDateTime(dateFechaFin.Value.ToShortDateString());
            parametros.Nombre = txtNombre.Text;
            funcion.buscarSustitucionesEmpleado(ref dt, parametros);
            tablaSustituciones.DataSource = dt;
        }
        private void mostraSustituciones()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarSustitucion(ref dt);
            tablaSustituciones.DataSource = dt;
        }
        private void eliminarSustitucion()
        {
            Sustituciones parametros = new Sustituciones();
            DMedicos funcion = new DMedicos();
            parametros.Nombre = tablaSustituciones.SelectedCells[3].Value.ToString();
            parametros.FechaInicio = Convert.ToDateTime(tablaSustituciones.SelectedCells[1].Value.ToString());
            parametros.FechaFin = Convert.ToDateTime(tablaSustituciones.SelectedCells[2].Value.ToString());
            if (funcion.eliminarSustitucion(parametros) == true)
            {
                MessageBox.Show("Sustitucion eliminada con exito...", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                mostraSustituciones();
            }
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
            mostraSustituciones();
        }

        private void btnBuscarSustitucion_Click(object sender, EventArgs e)
        {
            buscarSustituciones();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSustitucionesEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                buscarSustitucionesEmpleado();
            }
            else if (txtNombre.Text == "")
            {
                mostraSustituciones();
            }
        }

        private void mostrarTodo_Click(object sender, EventArgs e)
        {
            mostraSustituciones();
        }

        private void tablaSustituciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaSustituciones.Columns["Eliminar"].Index)
            {

                DialogResult result = MessageBox.Show("Desea Eliminar la Sustitucion Seleccionada?", "Asignar Horario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminarSustitucion();
                }
                if (result == DialogResult.Cancel)
                {
                    mostraSustituciones();
                }
            }
        }
    }
}
