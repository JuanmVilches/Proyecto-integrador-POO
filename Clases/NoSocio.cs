namespace Proyecto_integrador_club_deportivo.Clases
{
    internal class NoSocio: Alumno
    {
        public NoSocio(int identificador, int documento, string nombre, string apellido, bool apto_fisico, string actividad)
           : base(identificador, documento, nombre, apellido, false, apto_fisico, actividad) // esSocio = false
        { }

        public override void pagar()
        {
            base.pagar();
        }

        public override bool obtenerEstadoPago() { return false; }
    }
}