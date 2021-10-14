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
    class DPacientes
    {
        public void lista_Medico(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("nombre_y_licencia_medicos", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.Text;
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
        public void lista_Medico_interno(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("lista_Medico_interno", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.Text;
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

        public void lista_Enfermedad(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarEnfermedad", Conexion_BD.conectar);
                da.SelectCommand.CommandType = CommandType.Text;
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

        public bool insertarPacientes(Paciente parametros, Diagnostico parametros1,Medico parametros2)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("agregarPaciente", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", parametros.Telefono);
                cmd.Parameters.AddWithValue("@Municipio", parametros.Municipio);
                cmd.Parameters.AddWithValue("@Observaciones",parametros1.Observaciones);
                cmd.Parameters.AddWithValue("@Id_enfermedad", parametros1.Id_enfermedad);
                cmd.Parameters.AddWithValue("@Lic_medica", parametros2.Lic_medica);
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
        public void mostrarPacientes(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPaciente", Conexion_BD.conectar);
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
        public bool editarPaciente(Paciente parametros)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("editarPaciente", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", parametros.Telefono);
                cmd.Parameters.AddWithValue("@Municipio", parametros.Municipio);
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
        public bool eliminarPaciente(Paciente Paciente)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("eliminarPaciente", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", Paciente.Identificacion);
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
        public void mostrarEnfermedad(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarEnfermedad", Conexion_BD.conectar);
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
        public void buscarPaciente(ref DataTable dt, int i)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("datosPaciente", Conexion_BD.conectar);
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
        public void mostrarDatosPaciente(ref DataTable dt)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrarDatosPaciente", Conexion_BD.conectar);
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
        public void buscarDatosPaciente(ref DataTable dt, string nombre)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlDataAdapter da = new SqlDataAdapter("buscarDatosPaciente", Conexion_BD.conectar);
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
        public bool insertarDiagnostico(Diagnostico parametros, Medico parametrosM)
        {
            try
            {
                Conexion_BD.AbrirConexion();
                SqlCommand cmd = new SqlCommand("agregarDiagnostico", Conexion_BD.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Observaciones", parametros.Observaciones);
                cmd.Parameters.AddWithValue("@Idenfermedad", parametros.Id_enfermedad);
                cmd.Parameters.AddWithValue("@Idpaciente", parametros.Id_paciente);
                cmd.Parameters.AddWithValue("@Licencia", parametrosM.Lic_medica);
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
    }
}
