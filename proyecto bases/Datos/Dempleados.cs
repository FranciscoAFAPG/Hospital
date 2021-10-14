using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_bases.Logica
{

    public class Dempleados
    {
        public void mostrarEmpleados(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarEmpleado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }


        public string cont()
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cont_empleados", Conexion_BD.conectar);
                string reg=Convert.ToString(da.SelectCommand.ExecuteScalar());
                return reg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return null;
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }

        

        public void mostrarTodoPersonal(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarListaEmpleado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }

        public bool insertarEmpleados(Empleado parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("agregarEmpleado", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", parametros.Telefono);
                cmd.Parameters.AddWithValue("@Municipio", parametros.Municipio);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.Id_cargo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public bool editarEmpleado(Empleado parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("editarEmpleado", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", parametros.Telefono);
                cmd.Parameters.AddWithValue("@Municipio", parametros.Municipio);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.Id_cargo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public bool eliminarEmpleado(Empleado parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarEmpleado", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void mostrarCargo(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarCargo", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void mostrarCargoEmpleado(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarCargoEmpleado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void buscarVacaciones(ref DataTable dt,DateTime i, DateTime j,int z)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("validarVacaciones", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@i", i);
                da.SelectCommand.Parameters.AddWithValue("@j", j);
                da.SelectCommand.Parameters.AddWithValue("@z", z);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void buscarVacacionesEmpleado(ref DataTable dt, DateTime i, DateTime j, string z)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarVacacionesEmpleado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@i", i);
                da.SelectCommand.Parameters.AddWithValue("@j", j);
                da.SelectCommand.Parameters.AddWithValue("@z", z);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void mostrarVacaciones(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarVacaciones", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void buscarEmpleadoCargo(ref DataTable dt, int i)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarEmpleadoCargo", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@i", i);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void buscarEmpleado(ref DataTable dt, string i)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarEmpleado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@i", i);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public bool agregarVacaciones(Vacacion parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("agregarVacaciones", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@FechaInicio", parametros.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", parametros.FechaFin);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public bool eliminarVacacion(Vacacion parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarVacacion", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@FechaInicio", parametros.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", parametros.FechaFin);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void buscarHorario(ref DataTable dt, int dia)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarHorario", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@dia", dia);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void buscarDia(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarDia", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void mostrarExempleado(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarExempleado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public bool eliminarExempleado(Exempleado parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarExempleado", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void buscarExempleado(ref DataTable dt, string nombre)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarExempleado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
        public void buscarExempleadoCargo(ref DataTable dt, int cargo)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarExempleadoCargo", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@cargo", cargo);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
    }
}