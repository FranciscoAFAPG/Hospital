using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Net;

namespace proyecto_bases.Logica
{
    class Conexion_BD
    {
        public static string conexion = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\baseDatos\\hospital.mdf;Integrated Security = false";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void CerrarConexion()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
        public static void AbrirConexion()
        {
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

    }
}
