namespace Proyecto_integrador_club_deportivo.Clases
{
    internal class Pago
    {
        private int id_pago;
        private DateTime periodoInicio;
        private DateTime periodoFin;
        private int identificadorAlumno;

        public Pago(DateTime periodoInicio, DateTime periodoFin, int identificadorAlumno)
        {
            this.periodoInicio = periodoInicio;
            this.periodoFin = periodoFin;
            this.identificadorAlumno = identificadorAlumno;
        }
        public DateTime PeriodoInicio
        {
            get { return periodoInicio; }
            set { periodoInicio = value; }
        }

        public DateTime PeriodoFin
        {
            get { return periodoFin; }
            set { periodoFin = value; }
        }

        public int IdentificadorAlumno
        {
            get { return identificadorAlumno; }
            set { identificadorAlumno = value; }
        }
    }
}
