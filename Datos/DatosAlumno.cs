using MySql.Data.MySqlClient;
using Proyecto_integrador_club_deportivo.Clases;
using System.Data;

namespace Proyecto_integrador_club_deportivo.Datos
{
    internal class DatosAlumno
    {
        public static bool ExisteAlumno(Alumno alumno)
        {
            string query = "SELECT COUNT(*) FROM Alumno WHERE documento = @documento";
            MySqlCommand existeAlumno = new MySqlCommand(query);
            existeAlumno.Parameters.AddWithValue("@documento", alumno.Documento);
            DataTable dt = EjecutarComando.EjecutarMySQLCommand(existeAlumno);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public static DataTable CrearAlumno(Alumno alumno)
        {
            MySqlCommand crearAlumno = new MySqlCommand("CrearAlumno");
            crearAlumno.CommandType = CommandType.StoredProcedure;
            crearAlumno.Parameters.AddWithValue("p_documento", alumno.Documento);
            crearAlumno.Parameters.AddWithValue("p_nombre", alumno.Nombre);
            crearAlumno.Parameters.AddWithValue("p_apellido", alumno.Apellido);
            crearAlumno.Parameters.AddWithValue("p_esSocio", alumno.EsSocio);
            crearAlumno.Parameters.AddWithValue("p_apto_fisico", alumno.Apto_fisico);
            crearAlumno.Parameters.AddWithValue("p_actividad", alumno.Actividad);
            return EjecutarComando.EjecutarMySQLCommand(crearAlumno);
        }
        public static List<Alumno> LeerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            MySqlCommand leerAlumnos = new MySqlCommand("LeerAlumnos");
            leerAlumnos.CommandType = CommandType.StoredProcedure;
            DataTable datosAlumnos = EjecutarComando.EjecutarMySQLCommand(leerAlumnos);
            foreach(DataRow row in datosAlumnos.Rows)
            {
                Alumno alumno;

                if (row["esSocio"].ToString() == "True")
                {
                    alumno = new Socio(
                        Convert.ToInt32(row["identificador"].ToString()),
                        Convert.ToInt32(row["documento"]),
                        row["nombre"].ToString(),
                        row["apellido"].ToString(),
                        Transformar.Fecha(row["vencimiento"].ToString()),
                        row["apto_fisico"].ToString() == "True",
                        row["actividad"].ToString()
                    );
                }
                else
                {
                    alumno = new NoSocio(
                        Convert.ToInt32(row["identificador"].ToString()),
                        Convert.ToInt32(row["documento"]),
                        row["nombre"].ToString(),
                        row["apellido"].ToString(),
                        Transformar.Fecha(row["vencimiento"].ToString()),
                        row["apto_fisico"].ToString() == "True",
                        row["actividad"].ToString()
                    );
                }
                alumno.Pagos = DatosPago.LeerPagosAlumno(alumno);
                alumnos.Add(alumno);
            }
            return alumnos;
        }
    }
}