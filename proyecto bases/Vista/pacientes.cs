using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using proyecto_bases.Logica;

namespace proyecto_bases
{
    public partial class pacientes : Form
    {
        public pacientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pacientes_Load(object sender, EventArgs e)
        {

            txt_diagnostico_pac.Enabled = false;
            txt_diagnostico_pac.Text = "Paciente con diagnostico de " + list_enfermedad.Text;
            listaMedico();
            listaEnfermedad();
            MostrarPaciente();
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void Boton_crear_paciente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_identificacion_pac.Text))
            {
                if (!string.IsNullOrEmpty(txt_nombre_pac.Text))
                {
                    if (!string.IsNullOrEmpty(list_enfermedad.Text) && list_enfermedad.Text != "Seleccione...")
                    {
                        if (!string.IsNullOrEmpty(txt_municipio_pac.Text))
                        {
                            if (!string.IsNullOrEmpty(txt_telefono_pac.Text))
                            {
                                if (!string.IsNullOrEmpty(txt_direccion_pac.Text))
                                {
                                    insertarPaciente();
                                    Limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Digite la dirección", "Agregar Empleado", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Digite el telefono", "Agregar Empleado", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite el municipio", "Agregar Empleado", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la enfermedad", "Agregar Empleado", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Digite el nombre", "Agregar Empleado", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Digite la identificación", "Agregar Empleado", MessageBoxButtons.OK);
            }
        }
        private void insertarPaciente()
        {
            Paciente parametros = new Paciente();
            DPacientes funcion = new DPacientes();
            Diagnostico parametros1 = new Diagnostico();
            Medico parametros2 = new Medico();
            if (Convert.ToInt64(txt_identificacion_pac.Text) >= 2147483647)
            {
                MessageBox.Show("la identificaciocion no es valida, tiene mas digitos de lo permitido", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else 
            {
                parametros.Identificacion = Convert.ToInt32(txt_identificacion_pac.Text);
                parametros.Nombre = txt_nombre_pac.Text;
                parametros.Direccion = txt_direccion_pac.Text;
                parametros.Telefono = txt_telefono_pac.Text;
                parametros.Municipio = txt_municipio_pac.Text;
                parametros1.Observaciones = txt_diagnostico_pac.Text;
                parametros1.Id_enfermedad = Convert.ToInt32(list_enfermedad.SelectedValue);
                parametros1.Id_paciente = Convert.ToInt32(txt_identificacion_pac.Text);
                parametros2.Lic_medica = Convert.ToInt32(list_medico.SelectedValue);
            }

                
            if (funcion.insertarPacientes(parametros, parametros1,parametros2) == true)
            {
                MessageBox.Show("El Paciente se ha guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                MostrarPaciente();
            }
            else
            {
                MessageBox.Show("Paciento no guardado con exito...","", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void MostrarPaciente()
        {
            DataTable dt = new DataTable();
            DPacientes funcion = new DPacientes();
            funcion.mostrarPacientes(ref dt);
            tablaPaciente.DataSource = dt;
            Boton_crear_paciente.Visible = true;
        }
        private void Limpiar()
        {
            txt_diagnostico_pac.Text = "";
            txt_identificacion_pac.Text = "";
            txt_nombre_pac.Text = "";
            txt_direccion_pac.Text = "";
            txt_telefono_pac.Text = "";
            txt_municipio_pac.Text = "";
            txt_diagnostico_pac.Enabled = true;
            list_enfermedad.Enabled = true;
            list_medico.Enabled = true;
        }

        private void list_enfermedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_diagnostico_pac.Text = "Paciente con diagnostico de " + list_enfermedad.Text;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_identificacion_pac.Text))
            {
                if (!string.IsNullOrEmpty(txt_nombre_pac.Text))
                {
                    if (!string.IsNullOrEmpty(list_enfermedad.Text) && list_enfermedad.Text != "Seleccione...")
                    {
                        if (!string.IsNullOrEmpty(txt_municipio_pac.Text))
                        {
                            if (!string.IsNullOrEmpty(txt_telefono_pac.Text))
                            {
                                if (!string.IsNullOrEmpty(txt_direccion_pac.Text))
                                {
                                    editarPaciente();
                                    Limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Digite la dirección", "Agregar Empleado", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Digite el telefono", "Agregar Empleado", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite el municipio", "Agregar Empleado", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la enfermedad", "Agregar Empleado", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Digite el nombre", "Agregar Empleado", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Digite la identificación", "Agregar Empleado", MessageBoxButtons.OK);
            }
            
        }
        int id_paciente;
        private void editarPaciente()
        {
            Paciente parametros = new Paciente();
            DPacientes funcion = new DPacientes();
            parametros.Identificacion = id_paciente;
            parametros.Nombre = txt_nombre_pac.Text;
            parametros.Direccion = txt_direccion_pac.Text;
            parametros.Telefono = txt_telefono_pac.Text;
            parametros.Municipio = txt_municipio_pac.Text;
            if (funcion.editarPaciente(parametros) == true)
            {
                Limpiar();
                MostrarPaciente();
                btnEditar.Visible = false;
            }
        }

        private void listaMedico()//funcion para mostrar medicos en el la lista de medicos"
        {
            DataTable dt = new DataTable();
            DPacientes funcion = new DPacientes();
            funcion.lista_Medico_interno(ref dt);
            list_medico.DataSource = dt;
            list_medico.DisplayMember = "nombre_emp";
            list_medico.ValueMember = "lic_medica";
            list_medico.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void listaEnfermedad()
        {
            DataTable dt = new DataTable();
            DPacientes funcion = new DPacientes();
            funcion.lista_Enfermedad(ref dt);
            list_enfermedad.DataSource = dt;
            list_enfermedad.DisplayMember = "nombre_enf";
            list_enfermedad.ValueMember = "id_enfermedad";
            list_enfermedad.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void obtenerPaciente()
        {
            txt_identificacion_pac.Enabled = false;
            txt_diagnostico_pac.Enabled = false;
            list_enfermedad.Enabled = false;
            list_medico.Enabled = false;
            txt_identificacion_pac.Text = tablaPaciente.SelectedCells[2].Value.ToString();
            id_paciente = Convert.ToInt32(tablaPaciente.SelectedCells[2].Value);
            txt_nombre_pac.Text = tablaPaciente.SelectedCells[3].Value.ToString();
            txt_direccion_pac.Text = tablaPaciente.SelectedCells[4].Value.ToString();
            txt_telefono_pac.Text = tablaPaciente.SelectedCells[5].Value.ToString();
            txt_municipio_pac.Text = tablaPaciente.SelectedCells[6].Value.ToString();
            txt_diagnostico_pac.Text = tablaPaciente.SelectedCells[7].Value.ToString();
            list_medico.Text = tablaPaciente.SelectedCells[8].Value.ToString();
            list_enfermedad.Text = tablaPaciente.SelectedCells[7].Value.ToString().Substring(28);

            btnEditar.Visible = true;
            Boton_crear_paciente.Visible = false;
        }

        private void eliminarPaciente()
        {
            id_paciente = Convert.ToInt32(tablaPaciente.SelectedCells[2].Value);
            Paciente parametros = new Paciente();
            DPacientes funcion = new DPacientes();
            parametros.Identificacion = id_paciente;
            Boton_crear_paciente.Visible = false;
            if (funcion.eliminarPaciente(parametros) == true)
            {
                MostrarPaciente();
            }
        }

        private void tablaPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaPaciente.Columns["Editar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Editar el Paciente?", "Editar Paciente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    obtenerPaciente();
                }
            }
            if (e.ColumnIndex == tablaPaciente.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Eliminar el Paciente?", "Eliminar Paciente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminarPaciente();
                    Limpiar();

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void list_medico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_identificacion_pac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números");
            }
        }

        private void txt_nombre_pac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }

        private void txt_telefono_pac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números");
            }
        }

        private void txt_municipio_pac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }
    }
}
