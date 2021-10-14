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
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
        }
        int id_empleado;
        private void Limpiar()
        {
            txt_direccion_emp.Text = "";
            txt_identificacion_emp.Text = "";
            txt_municipio_emp.Text = "";
            txt_nombre_emp.Text = "";
            txt_telefono_emp.Text = "";
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            txt_identificacion_emp.Enabled = true;
        }
        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            
            Dempleados funcion = new Dempleados();
            funcion.mostrarEmpleados(ref dt); 
            cont.Text=funcion.cont();
            tablaEmpleado.DataSource = dt;
            Boton_crear_empleado.Visible = true;
        }
        private void insertarPersonal()
        {
            Empleado parametros = new Empleado();
            Dempleados funcion = new Dempleados();
            if (Convert.ToInt64(txt_identificacion_emp.Text) >= 2147483647)
            {
                MessageBox.Show("la identificaciocion no es valida, tiene mas digitos de lo permitido", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else 
            {
               
                parametros.Identificacion = Convert.ToInt32(txt_identificacion_emp.Text);
                parametros.Nombre = txt_nombre_emp.Text;
                parametros.Id_cargo = list_cargo.Text;
                parametros.Municipio = txt_municipio_emp.Text;
                parametros.Telefono = txt_telefono_emp.Text;
                parametros.Direccion = txt_direccion_emp.Text;
            }

           
            if (funcion.insertarEmpleados(parametros) == true)
            {
                MessageBox.Show("El Empleado se ha guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                MostrarPersonal();
            }
        }
        private void mostrarCargo()
        {
            DataTable dt = new DataTable();
            Dempleados funcion = new Dempleados();
            funcion.mostrarCargoEmpleado(ref dt);
            list_cargo.DataSource = dt;
            list_cargo.ValueMember = "id_cargo";
            list_cargo.DisplayMember = "nombre_cargo";
            list_cargo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void obtenerEmpleado()
        {
            txt_identificacion_emp.Enabled = false;
            txt_identificacion_emp.Text = tablaEmpleado.SelectedCells[2].Value.ToString();
            id_empleado = Convert.ToInt32(tablaEmpleado.SelectedCells[2].Value);
            txt_nombre_emp.Text = tablaEmpleado.SelectedCells[3].Value.ToString();
            txt_direccion_emp.Text = tablaEmpleado.SelectedCells[4].Value.ToString();
            txt_telefono_emp.Text = tablaEmpleado.SelectedCells[5].Value.ToString();
            txt_municipio_emp.Text = tablaEmpleado.SelectedCells[6].Value.ToString();
            list_cargo.Text = tablaEmpleado.SelectedCells[7].Value.ToString();
            btnEditar.Visible = true;
            Boton_crear_empleado.Visible = false;
        }
        private void editarEmpleado()
        {
            Empleado parametros = new Empleado();
            Dempleados funcion = new Dempleados();
            parametros.Identificacion = id_empleado;
            parametros.Nombre = txt_nombre_emp.Text;
            parametros.Telefono = txt_telefono_emp.Text;
            parametros.Municipio = txt_municipio_emp.Text;
            parametros.Id_cargo = list_cargo.Text;
            parametros.Direccion = txt_direccion_emp.Text;
            if (funcion.editarEmpleado(parametros) == true)
            {
                Limpiar();
                MostrarPersonal();
                btnEditar.Visible = false;
            }
        }
        private void eliminarEmpleado()
        {
            id_empleado = Convert.ToInt32(tablaEmpleado.SelectedCells[2].Value);
            Empleado parametros = new Empleado();
            Dempleados funcion = new Dempleados();
            parametros.Identificacion = id_empleado;
            Boton_crear_empleado.Visible = false;
            if (funcion.eliminarEmpleado(parametros) == true)
            {
                MostrarPersonal();
            }
        }

        private void tablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tablaEmpleado.Columns["Editar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Editar el Empleado?", "Editar empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result==DialogResult.OK)
                {
                    obtenerEmpleado();
                }
            }
            if (e.ColumnIndex == tablaEmpleado.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Eliminar el Empleado?", "Editar empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminarEmpleado();
                    Limpiar();
                }
            }
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            MostrarPersonal();
            mostrarCargo();
            cont.Enabled = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }
        private void Boton_crear_empleado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_identificacion_emp.Text))
            {
                if (!string.IsNullOrEmpty(txt_nombre_emp.Text))
                {
                    if (!string.IsNullOrEmpty(list_cargo.Text) && list_cargo.Text!= "Seleccione...")
                    {
                        if (!string.IsNullOrEmpty(txt_municipio_emp.Text))
                        {
                            if (!string.IsNullOrEmpty(txt_telefono_emp.Text))
                            {
                                if (!string.IsNullOrEmpty(txt_direccion_emp.Text))
                                {
                                    insertarPersonal();
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
                        MessageBox.Show("Seleccione el cargo", "Agregar Empleado", MessageBoxButtons.OK);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_identificacion_emp.Text))
            {
                if (!string.IsNullOrEmpty(txt_nombre_emp.Text))
                {
                    if (!string.IsNullOrEmpty(list_cargo.Text) && list_cargo.Text != "Seleccione...")
                    {
                        if (!string.IsNullOrEmpty(txt_municipio_emp.Text))
                        {
                            if (!string.IsNullOrEmpty(txt_telefono_emp.Text))
                            {
                                if (!string.IsNullOrEmpty(txt_direccion_emp.Text))
                                {
                                    editarEmpleado();
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
                        MessageBox.Show("Seleccione el cargo", "Agregar Empleado", MessageBoxButtons.OK);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void list_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_cargo.Text == "Seleccione...")
            {
                mostrarCargo();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_identificacion_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) 
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números");
            }
        }

        private void txt_nombre_emp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }

        private void txt_municipio_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }

        private void txt_telefono_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números");
            }
        }
    }
    
    
}
