using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_integrador_club_deportivo.Datos
{
    internal class EjecutarComando
    {
        public static DataTable EjecutarMySQLCommand(MySqlCommand command)
        {
            MySqlConnection conexion = new MySqlConnection();
            DataTable datos = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                conexion.Open();
                command.Connection = conexion;
                resultado = command.ExecuteReader();
                datos.Load(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrio un error al consultar la base de datos: "
                        + ex.Message
                        + " La aplicacion se cerrará.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Application.Exit();
            }
            finally
            {
                conexion.Close();
            }
            return datos;
        }
    }
}