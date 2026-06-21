namespace Proyecto_integrador_club_deportivo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscribirAlumno inscribirPosulante = new frmInscribirAlumno();
            inscribirPosulante.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                btnSalir_Click(sender, e);
            }
        }
        private void btnVerInscriptos_Click(object sender, EventArgs e)
        {
            frmVerInscriptos verInscriptos = new frmVerInscriptos();
            verInscriptos.ShowDialog();
        }
        private void btnEmitirComprobante_Click(object sender, EventArgs e)
        {
            frmVencimientos frm = new frmVencimientos();
            frm.ShowDialog();
        }
    }
}