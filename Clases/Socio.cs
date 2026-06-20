namespace Proyecto_integrador_club_deportivo.Clases
{
    internal class Socio : Alumno
    {
        private DateTime vencimiento;
        public Socio(int identificador, int documento, string nombre, string apellido, DateTime vencimiento, bool apto_fisico, string actividad)
            : base(identificador, documento, nombre, apellido, true, apto_fisico, actividad) // esSocio = true
        {
            this.vencimiento = vencimiento;
        }
        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
        public override string obtenerEstadoPago()
        {
            if(this.pagos.Count < 1)
            {
                return "Sin pagos";
            }
            else
            {
                DateTime hoy = DateTime.Today;
                foreach (Pago pago in this.pagos)
                {
                    if (hoy >= pago.PeriodoInicio.Date && hoy <= pago.PeriodoFin.Date)
                    {
                        return "Al día";
                    }
                }
                return "Vencido";
            }
        }
    }
}