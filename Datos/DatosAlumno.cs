using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace Proyecto_integrador_club_deportivo.Datos
{
    internal class DatosAlumno
    {
        public static int CrearAlumno(Alumno alumno)
        {
            DataTable tabla = new DataTable();

            try
            {
                MySqlConnection conexion =
                    Conexion.getInstancia().CrearConexion();

                conexion.Open();

                MySqlCommand cmd =
                    new MySqlCommand("CrearAlumno", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_documento", alumno.Documento);
                cmd.Parameters.AddWithValue("p_nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("p_apellido", alumno.Apellido);
                cmd.Parameters.AddWithValue("p_esSocio", alumno.EsSocio);
                cmd.Parameters.AddWithValue("p_apto_fisico", alumno.apto_fisico);
                cmd.Parameters.AddWithValue("p_actividad", alumno.actividad);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);

                conexion.Close();

                return Convert.ToInt32(
                    tabla.Rows[0]["identificador"]
                );
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable LeerAlumnos()
        {
            DataTable tabla = new DataTable();

            try
            {
                MySqlConnection conexion =
                    Conexion.getInstancia().CrearConexion();

                conexion.Open();

                MySqlCommand cmd =
                    new MySqlCommand("LeerAlumnos", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da =
                    new MySqlDataAdapter(cmd);

                da.Fill(tabla);

                conexion.Close();

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable LeerVencimientosHoy()
        {
            DataTable tabla = new DataTable();

            MySqlConnection conexion =
                Conexion.getInstancia().CrearConexion();

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("LeerVencimientosHoy", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(tabla);

            conexion.Close();

            return tabla;
        }
    }
}
