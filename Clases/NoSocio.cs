namespace Proyecto_integrador_club_deportivo.Clases
{
    internal class NoSocio: Alumno
    {
        public NoSocio(int identificador, int documento, string nombre, string apellido, bool apto_fisico, string actividad)
           : base(identificador, documento, nombre, apellido, false, apto_fisico, actividad) // esSocio = false
        { }
        public override string obtenerEstadoPago()
        {
            if (this.pagos.Count < 1)
            {
                return "Sin pagos";
            }
            else
            {
                DateTime hoy = DateTime.Today;
                foreach (Pago pago in this.pagos)
                {
                    if (hoy == pago.PeriodoFin.Date)
                    {
                        return "Al día";
                    }
                }
                return "Vencido";
            }
        }
    }
}