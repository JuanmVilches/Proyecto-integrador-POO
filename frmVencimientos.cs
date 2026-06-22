using Proyecto_integrador_club_deportivo.Datos;
using Proyecto_integrador_club_deportivo.Clases;

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
            List<string> ordenColumnas = ["Documento", "Nombre", "Apellido", "EsSocio", "Apto_fisico", "Actividad", "Vencimiento"];

            List<Alumno> alumnosConVencimientoHoy = DatosPago.LeerVencimientosHoy();
            dgvVencimientos.DataSource = alumnosConVencimientoHoy;

            for (int i = 0; i < ordenColumnas.Count; i++)
            {
                dgvVencimientos.Columns[ordenColumnas[i]].DisplayIndex = i;
            }

            dgvVencimientos.Columns["Apto_fisico"].HeaderText = "Apto Fisico";
            dgvVencimientos.Columns["EsSocio"].HeaderText = "Socio";
            dgvVencimientos.Columns["Identificador"].Visible = false;
            dgvVencimientos.Columns["vencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvVencimientos.ReadOnly = true;
            dgvVencimientos.AllowUserToAddRows = false;
            dgvVencimientos.AllowUserToDeleteRows = false;
        }
    }
}