using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using proyecto_bases.Logica;

namespace proyecto_bases
{
    public partial class medicos : Form
    {
        public medicos()
        {
            InitializeComponent();


        }
        private void Boton_crear_medico_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_identificacion_med.Text))
            {
                if (!string.IsNullOrEmpty(txt_nombre_med.Text))
                {
                    if (!string.IsNullOrEmpty(txt_municipio_med.Text))
                    {
                        if (!string.IsNullOrEmpty(txt_telefono_med.Text))
                        {
                            if (!string.IsNullOrEmpty(txt_direccion_med.Text))
                            {
                                if (!string.IsNullOrEmpty(txt_lic_medica.Text))
                                {
                                    if (list_especialidad.Text != "Seleccione...")
                                    {
                                        insertarMedico();
                                        Limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione la especialidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Digite la licencia medica", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Digite la dirección", "Editar Medico", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite el telefono", "Editar Medico", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite el municipio", "Editar Medico", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Digite el nombre", "Editar Medico", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Digite la identificación", "Editar Empleado", MessageBoxButtons.OK);
            }
        }

        private void medicos_Load(object sender, EventArgs e)
        {
            mostrarEspecialidad();
            mostrarTipoMedico();
            MostrarMedico();
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void Boton_modificar_medico_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_identificacion_med.Text))
            {
                if (!string.IsNullOrEmpty(txt_nombre_med.Text))
                {
                    if (!string.IsNullOrEmpty(txt_municipio_med.Text))
                    {
                        if (!string.IsNullOrEmpty(txt_telefono_med.Text))
                        {
                            if (!string.IsNullOrEmpty(txt_direccion_med.Text))
                            {
                                if (!string.IsNullOrEmpty(txt_lic_medica.Text))
                                {
                                    if (list_especialidad.Text != "Seleccione...")
                                    {
                                        editarMedico();
                                        Limpiar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione la especialidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Digite la licencia medica", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Digite la dirección", "Editar Medico", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite el telefono", "Editar Medico", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite el municipio", "Editar Medico", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Digite el nombre", "Editar Medico", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Digite la identificación", "Editar Empleado", MessageBoxButtons.OK);
            }
        }

        private void Limpiar()
        {
            txt_lic_medica.Text = "";
            txt_identificacion_med.Text = "";
            txt_nombre_med.Text = "";
            txt_direccion_med.Text = "";
            txt_telefono_med.Text = "";
            txt_municipio_med.Text = "";
            txt_identificacion_med.Enabled = true;
            txt_lic_medica.Enabled = true;
            list_especialidad.Enabled = true;
            list_tipo_medico.Enabled = true;
        }

        private void mostrarEspecialidad()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarEspecialidad(ref dt);
            list_especialidad.DataSource = dt;
            list_especialidad.ValueMember = "id_especialidad";
            list_especialidad.DisplayMember = "nombre_esp";
            list_especialidad.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void mostrarTipoMedico()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarTipoMedico(ref dt);
            list_tipo_medico.DataSource = dt;
            list_tipo_medico.ValueMember = "id_tipo_medico";
            list_tipo_medico.DisplayMember = "nombre_tp";
            list_tipo_medico.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        private void tablaMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaMedico.Columns["Editar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Editar el Médico?", "Editar medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    obtenerMedico();
                    //Limpiar();
                }
            }
            if (e.ColumnIndex == tablaMedico.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Eliminar el Medico?", "Editar Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminarMedico();
                    Limpiar();
                }
            }
        }
        int id_medico;

        private void insertarMedico()
        {
            Empleado parametros = new Empleado();
            Dempleados funcion = new Dempleados();
            Medico parametros1 = new Medico();
            DMedicos funcion1 = new DMedicos();

            if (Convert.ToInt64(txt_identificacion_med.Text)>= 2147483647) 
            {
                MessageBox.Show("la identificaciocion no es valida, tiene mas digitos de lo permitido", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                parametros.Identificacion = Convert.ToInt32(txt_identificacion_med.Text);
                parametros.Nombre = txt_nombre_med.Text;
                parametros.Direccion = txt_direccion_med.Text;
                parametros.Telefono = txt_telefono_med.Text;
                parametros.Municipio = txt_municipio_med.Text;
                parametros1.Lic_medica = Convert.ToInt32(txt_lic_medica.Text);
                parametros1.Id_tipo_medico = Convert.ToInt32(list_tipo_medico.SelectedValue);
                parametros1.Id_especialidad = Convert.ToInt32(list_especialidad.SelectedValue);

            }

           
            if (funcion1.insertarMedicos(parametros, parametros1) == true)
            {
                MessageBox.Show("El medico se ha guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                MostrarMedico();
            }
            else
            {
                
                MessageBox.Show("Medico no guardado con exito...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        private void obtenerMedico()
        {
            txt_identificacion_med.Enabled = false;
            txt_lic_medica.Enabled = false;
            list_especialidad.Enabled = false;
            list_tipo_medico.Enabled = false;
            txt_identificacion_med.Text = tablaMedico.SelectedCells[2].Value.ToString();
            id_medico = Convert.ToInt32(tablaMedico.SelectedCells[2].Value);
            txt_lic_medica.Text = tablaMedico.SelectedCells[3].Value.ToString();
            txt_nombre_med.Text = tablaMedico.SelectedCells[4].Value.ToString();
            txt_direccion_med.Text = tablaMedico.SelectedCells[5].Value.ToString();
            txt_telefono_med.Text = tablaMedico.SelectedCells[6].Value.ToString();
            txt_municipio_med.Text = tablaMedico.SelectedCells[7].Value.ToString();
            list_tipo_medico.Text = tablaMedico.SelectedCells[8].Value.ToString();
            list_especialidad.Text = tablaMedico.SelectedCells[9].Value.ToString();

            btnEditar.Visible = true;
            Boton_crear_medico.Visible = false;

        }
        private void eliminarMedico()
        {
            id_medico = Convert.ToInt32(tablaMedico.SelectedCells[2].Value);
            Medico parametros = new Medico();
            DMedicos funcion = new DMedicos();
            parametros.Id_identificacion = id_medico;
            Boton_crear_medico.Visible = false;
            if (funcion.eliminarMedico(parametros) == true)
            {
                MostrarMedico();
            }
        }
        private void MostrarMedico()
        {
            DataTable dt = new DataTable();
            DMedicos funcion = new DMedicos();
            funcion.mostrarMedicos(ref dt);
            tablaMedico.DataSource = dt;
            Boton_crear_medico.Visible = true;
        }
        private void editarMedico()
        {

            Empleado parametros = new Empleado();
            Medico parametros1 = new Medico();
            DMedicos funcion1 = new DMedicos();

            parametros.Identificacion = id_medico;
            parametros.Nombre = txt_nombre_med.Text;
            parametros.Direccion = txt_direccion_med.Text;
            parametros.Telefono = txt_telefono_med.Text;
            parametros.Municipio = txt_municipio_med.Text;
            parametros1.Id_tipo_medico = Convert.ToInt32(list_tipo_medico.SelectedValue);

            if (funcion1.editarMedico(parametros, parametros1) == true)
            {
                Limpiar();
                MostrarMedico();
                btnEditar.Visible = false;
            }
        }

        private void list_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void list_tipo_medico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_identificacion_med_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_identificacion_med_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números");
            }
        }

        private void txt_nombre_med_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }

        private void txt_direccion_med_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_direccion_med_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_telefono_med_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_med_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números");
            }
        }

        private void txt_municipio_med_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }

        private void txt_lic_medica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números");
            }
        }
    }
}
