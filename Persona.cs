namespace Proyecto_integrador_club_deportivo
{
    internal class Persona
    {
        private int identificador;
        private string nombre;
        private string apellido;

        public Persona(int identificador, string nombre, string apellido)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public int Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

    }
}