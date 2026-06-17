using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_integrador_club_deportivo.Datos
{
    internal class DatosUsuario
    {
        public static bool Ingresar(string usuario, string clave)
        {
            MySqlCommand Ingresar = new MySqlCommand("Ingresar");

            Ingresar.CommandType = CommandType.StoredProcedure;

            Ingresar.Parameters.Add("p_usuario", MySqlDbType.VarChar).Value = usuario;
            Ingresar.Parameters.Add("p_clave", MySqlDbType.VarChar).Value = clave;

            // retorna true cuando los datos estan OK
            return EjecutarComando.EjecutarMySQLCommand(Ingresar).Rows.Count == 1; 
        }
    }
}