using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_integrador_club_deportivo.Datos
{
    internal class DatosPago
    {
        public static void RegistrarPago(Pago pago)
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();

            conexion.Open();

            MySqlCommand cmd =
                new MySqlCommand(
                    "RegistrarPago",
                    conexion);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "p_inicio",
                pago.PeriodoInicio);

            cmd.Parameters.AddWithValue(
                "p_fin",
                pago.PeriodoFin);

            cmd.Parameters.AddWithValue(
                "p_alumno",
                pago.IdentificadorAlumno);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
