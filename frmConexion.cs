using Proyecto_integrador_club_deportivo.Datos;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Conexion.ConfigurarConexion(
                lwcboBasedatos.Text,
                lwcboServidor.Text,
                lwcboPuerto.Text,
                lwcboUsuario.Text,
                lwcboClave.Text
            );
            Close();
        }
    }
}