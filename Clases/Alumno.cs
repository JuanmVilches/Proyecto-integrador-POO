namespace Proyecto_integrador_club_deportivo.Clases
{
    internal class Alumno : Persona
    {
        protected List<Pago> pagos; // Cuando este crada la clase Pago sera List<Pago>
        protected List<string> rutinas; // Cuando este creada la clase Rutina sera List<Rutina>
        protected bool esSocio;
        private bool apto_fisico1;
        protected string actividad;
        public Alumno(int identificador, int documento, string nombre, string apellido, bool esSocio, bool apto_fisico, string actividad)
            : base(identificador, documento, nombre, apellido)
        {
            this.esSocio = esSocio;
            this.pagos = new List<Pago>();
            this.rutinas = new List<string>();
            this.Apto_fisico = apto_fisico;
            this.actividad = actividad;
        }
        public void agregarPago(Pago pago)
        {
            this.pagos.Add(pago);
        }
        public List<Pago> Pagos { get => pagos; set => pagos = value; }
        public List<string> Rutinas { get => rutinas; set => rutinas = value; }
        public bool EsSocio { get => esSocio; set => esSocio = value; }
        protected bool Apto_fisico { get => Apto_fisico1; set => Apto_fisico1 = value; }
        protected bool Apto_fisico1 { get => apto_fisico1; set => apto_fisico1 = value; }
        public virtual string obtenerEstadoPago() { return ""; }
    }
}