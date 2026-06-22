using System.Globalization;

namespace Proyecto_integrador_club_deportivo.Datos
{
    internal class Transformar
    {
        public static DateTime Fecha(string fecha)
        {
            if (fecha == "")
            {
                return DateTime.MinValue;
            }
            else
            {
                return DateTime.ParseExact(
                    fecha,
                   "d/M/yyyy HH:mm:ss",
                    CultureInfo.InvariantCulture
                );
            }
        }
    }
}