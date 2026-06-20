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

        public override void pagar()
        {
            
        }

        public override bool obtenerEstadoPago()
        {
            return this.vencimiento < DateTime.Today;
        }
    }
}