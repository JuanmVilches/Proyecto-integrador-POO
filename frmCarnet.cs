using Proyecto_integrador_club_deportivo.Clases;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmCarnet : Form
    {
        internal frmCarnet(Alumno alumno)
        {
            InitializeComponent();
            lblNombre.Text = alumno.Nombre + " " + alumno.Apellido;
            lblActividad.Text = alumno.Actividad;
            lblDocumento.Text = alumno.Documento.ToString();
            if (alumno.EsSocio) lblTipo.Text = "SOCIO";
            else lblTipo.Text = "NO SOCIO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Se imprimio correctamente el carnet",
                "Imprimir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
