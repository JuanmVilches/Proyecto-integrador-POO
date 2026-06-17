using MySql.Data.MySqlClient;

namespace Proyecto_integrador_club_deportivo.Datos
{
    public class Conexion
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion(string baseDatos, string servidor, string puerto, string usuario, string clave) 
        {
            this.baseDatos = baseDatos;
            this.servidor = servidor;
            this.puerto = puerto;
            this.usuario = usuario;
            this.clave = clave;
        }
        public static void ConfigurarConexion(string baseDatos, string servidor, string puerto, string usuario, string clave)
        {
            Conexion.con = new Conexion(baseDatos, servidor, puerto, usuario, clave);
        }
        public MySqlConnection CrearConexion() // proceso de interacción
        {
            MySqlConnection cadena = new MySqlConnection(); // instanciamos una conexion
            try  // el bloque try permite controlar errores
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
            return cadena;
        }
        public static bool hayInstancia()
        {
            if(con == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Conexion getInstancia()  // para evaluar la instancia de la conectividad
        {
            return con;
        }
    } 
}