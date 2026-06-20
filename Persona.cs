namespace Proyecto_integrador_club_deportivo
{
    internal class Persona
    {
        private int identificador;
        private int documento;
        private string nombre;
        private string apellido;
        public Persona(int identificador, int documento, string nombre, string apellido)
        {
            this.identificador = identificador;
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public int Identificador { get => identificador; set => identificador = value; }
        public int Documento { get => documento; set => documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}