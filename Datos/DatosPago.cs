using MySql.Data.MySqlClient;
using Proyecto_integrador_club_deportivo.Clases;
using System.Data;

namespace Proyecto_integrador_club_deportivo.Datos
{
    internal class DatosPago
    {
        public static void RegistrarPago(Pago pago)
        {
            MySqlCommand registrarPago = new MySqlCommand("RegistrarPago");
            registrarPago.CommandType = CommandType.StoredProcedure;
            registrarPago.Parameters.AddWithValue("p_inicio", pago.PeriodoInicio);
            registrarPago.Parameters.AddWithValue("p_fin", pago.PeriodoFin);
            registrarPago.Parameters.AddWithValue("p_alumno", pago.IdentificadorAlumno);
            EjecutarComando.EjecutarMySQLCommand(registrarPago);
        }
        public static List<Alumno> LeerVencimientosHoy()
        {
            List<Alumno> alumnos = new List<Alumno>();
            MySqlCommand leerVencimientosHoy = new MySqlCommand("LeerVencimientosHoy");
            leerVencimientosHoy.CommandType = CommandType.StoredProcedure;
            DataTable vencimientosHoy = EjecutarComando.EjecutarMySQLCommand(leerVencimientosHoy);
            foreach (DataRow dr in vencimientosHoy.Rows)
            {
                Alumno alumno = new Socio(
                    Convert.ToInt32(dr["identificador"].ToString()),
                    Convert.ToInt32(dr["documento"]),
                    dr["nombre"].ToString(),
                    dr["apellido"].ToString(),
                    Transformar.Fecha(dr["vencimiento"].ToString()),
                    true,
                    dr["actividad"].ToString()
                );
                alumnos.Add(alumno);
            }
            return alumnos;
        }
        public static List<Pago> LeerPagosAlumno(Alumno alumno)
        {
            List<Pago> pagos = new List<Pago>();
            string query = "SELECT * FROM Pago WHERE identificadorAlumno = @alumno";
            MySqlCommand pagosDelAlumno = new MySqlCommand(query);
            pagosDelAlumno.Parameters.AddWithValue("@alumno", alumno.Identificador);
            DataTable dt = EjecutarComando.EjecutarMySQLCommand(pagosDelAlumno);
            foreach (DataRow dr in dt.Rows)
            {
                Pago pago = new Pago(
                    Transformar.Fecha(dr["periodoInicio"].ToString()),
                    Transformar.Fecha(dr["periodoFin"].ToString()),
                    Convert.ToInt32(dr["identificadorAlumno"])
                );
                pagos.Add(pago);
            }
            return pagos;
        }
    }
}