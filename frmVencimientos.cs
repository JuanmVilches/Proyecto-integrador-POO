using Proyecto_integrador_club_deportivo.Datos;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmVencimientos : Form
    {
        public frmVencimientos()
        {
            InitializeComponent();
        }
        private void frmVencimientos_Load(object sender, EventArgs e)
        {
            dgvVencimientos.DataSource = DatosPago.LeerVencimientosHoy();

            dgvVencimientos.ReadOnly = true;
            dgvVencimientos.AllowUserToAddRows = false;
            dgvVencimientos.AllowUserToDeleteRows = false;

            dgvVencimientos.Columns["identificador"].Visible = false;

            dgvVencimientos.Columns["documento"].HeaderText =
                "Documento";

            dgvVencimientos.Columns["nombre"].HeaderText =
                "Nombre";

            dgvVencimientos.Columns["apellido"].HeaderText =
                "Apellido";

            dgvVencimientos.Columns["actividad"].HeaderText =
                "Actividad";

            dgvVencimientos.Columns["vencimiento"].HeaderText =
                "Vencimiento";

            dgvVencimientos.Columns["vencimiento"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}