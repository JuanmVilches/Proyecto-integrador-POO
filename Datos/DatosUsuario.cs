using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Proyecto_integrador_club_deportivo.Datos
{
    internal class DatosUsuario
    {
        private MySqlConnection conexion;
        public DatosUsuario()
        {
            conexion = new MySqlConnection(
                "server=localhost;database=Proyecto;uid=root;pwd=;"
            );
        }

        public DataTable Log_Usu(string usuario, string clave)
        {
            DataTable tabla = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("Ingresar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_usuario", usuario);
                cmd.Parameters.AddWithValue("p_clave", clave);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tabla;
        }
    }
}
