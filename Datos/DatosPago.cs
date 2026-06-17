using MySql.Data.MySqlClient;
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
        public static DataTable LeerVencimientosHoy()
        {
            MySqlCommand leerVencimientosHoy = new MySqlCommand("LeerVencimientosHoy");
            leerVencimientosHoy.CommandType = CommandType.StoredProcedure;
            return EjecutarComando.EjecutarMySQLCommand(leerVencimientosHoy);
        }
    }
}