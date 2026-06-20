namespace Proyecto_integrador_club_deportivo
{
    internal class Alumno : Persona
    {
        private List<string> pagos; // Cuando este crada la clase Pago sera List<Pago>
        private List<string> rutinas; // Cuando este creada la clase Rutina sera List<Rutina>
        private bool esSocio;
        public bool apto_fisico;
        public string actividad;
        public Alumno(int identificador, int documento, string nombre, string apellido, bool esSocio, bool apto_fisico, string actividad)
            : base(identificador, documento, nombre, apellido)
        {
            this.esSocio = esSocio;
            this.pagos = new List<string>();
            this.rutinas = new List<string>();
            this.apto_fisico = apto_fisico;
            this.actividad = actividad;
        }
        public List<string> Pagos { get => pagos; set => pagos = value; }
        public List<string> Rutinas { get => rutinas; set => rutinas = value; }
        public bool EsSocio { get => esSocio; set => esSocio = value; }
        public virtual void pagar() { }
        public virtual bool obtenerEstadoPago() { return true; }
    }
}