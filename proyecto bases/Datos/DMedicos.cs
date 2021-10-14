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
    class DMedicos
    {
        public void mostrarMedicos(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarMedico", Conexion_BD.conectar);
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

        public bool insertarMedicos(Empleado parametros, Medico parametros1)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("agregarMedico", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", parametros.Telefono);
                cmd.Parameters.AddWithValue("@Municipio", parametros.Municipio);
                cmd.Parameters.AddWithValue("@Lic_med", parametros1.Lic_medica);
                cmd.Parameters.AddWithValue("@Tipo_med", parametros1.Id_tipo_medico);
                cmd.Parameters.AddWithValue("@Especialidad", parametros1.Id_especialidad);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                SqlError err = ex.Errors[0];
                string mensaje = string.Empty;

                switch (err.Number)
                {
                    case 513:
                        MessageBox.Show("la licencia debe tener 8 digitos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
            finally
            {
                Conexion_BD.CerrarConexion();
            }
        }
            

        
        public bool eliminarMedico(Medico Medico)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarMedico", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", Medico.Id_identificacion);
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
        public bool editarMedico(Empleado parametros,Medico parametros1)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("editarMedico", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", parametros.Telefono);
                cmd.Parameters.AddWithValue("@Municipio", parametros.Municipio);
                cmd.Parameters.AddWithValue("@id_tipo_medico", parametros1.Id_tipo_medico);
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
        public void buscarMedico(ref DataTable dt, string i)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("pacientesAcargoMedico", Conexion_BD.conectar);
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
        public void buscarEspecialidad(ref DataTable dt, int i)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("pacientesAcargoMedicoEspecialidad", Conexion_BD.conectar);
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
        public void buscarPaciente(ref DataTable dt, string i)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("pacientesAtendido", Conexion_BD.conectar);
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
        public void mostrarListadoMedicoPaciente(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPacientesAcargoMedico", Conexion_BD.conectar);
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
        public void mostrarEspecialidad(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarEspecialidad", Conexion_BD.conectar);
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
        public void mostrarTipoMedico(ref DataTable dt)
            {
                try
                {
                    Conexion_BD.AbrirConexion();
                    SqlDataAdapter da = new SqlDataAdapter("mostrarTipoMedico", Conexion_BD.conectar);
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
        public void buscarDisponibilidad(ref DataTable dt, int i)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarDisponible", Conexion_BD.conectar);
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
        public void mostrarDisponible(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarDisponible", Conexion_BD.conectar);
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
        public void buscarSustituciones(ref DataTable dt, Sustituciones parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("validarSustitucion", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@i", parametros.FechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@j", parametros.FechaFin);
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
        public void buscarSustitucionesEmpleado(ref DataTable dt, Sustituciones parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("validarSustitucionEmpleado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@i", parametros.FechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@j", parametros.FechaFin);
                da.SelectCommand.Parameters.AddWithValue("@z", parametros.Nombre);
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
        public void mostrarSustitucion(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarSustitucion", Conexion_BD.conectar);
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
        public void mostrarMedicoSustituto(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarMedicoSustituto", Conexion_BD.conectar);
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
        public void buscarSustituto(ref DataTable dt,String nombre)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarSustituto", Conexion_BD.conectar);
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
        public bool agregarSustitucion(Sustituciones parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("agregarSustitucion", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Licencia", parametros.Licencia);
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
        public bool eliminarSustitucion(Sustituciones parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarSustitucion", Conexion_BD.conectar);
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
        public void mostrarHorarioAsignado(ref DataTable dt, int id)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarHorarioAsignado", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id", id);
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
        public bool insertarHorario(String HoraInicio, String HoraFin, int iddia, int id)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("insertarHorario", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HoraInicio", HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", HoraFin);
                cmd.Parameters.AddWithValue("@iddia", iddia);
                cmd.Parameters.AddWithValue("@id", id);
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
        public bool eliminarHorario(int id, int iddia)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarHorario", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@iddia", iddia);
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
        public void buscarMedicoHorario(ref DataTable dt, string Nombre)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarMedico", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Nombre", Nombre);
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
