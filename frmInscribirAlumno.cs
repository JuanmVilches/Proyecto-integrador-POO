using Proyecto_integrador_club_deportivo.Clases;
using Proyecto_integrador_club_deportivo.Datos;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmInscribirAlumno : Form
    {
        public frmInscribirAlumno()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDocumento.Text, out int documento))
            {
                MessageBox.Show(
                    "Ingrese un documento válido",
                    "Error en documento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show(
                    "Debe completar todos los datos para registrar un alumno",
                    "Error en datos de alumnos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            Alumno alumno;
            if (chkSocio.Checked)
            {
                DateTime venc = DateTime.Today.AddMonths(1); // o el valor que quieras asignar
                alumno = new Socio(0, documento, txtNombre.Text, txtApellido.Text, venc, chkAptoFisico.Checked, cmbActividad.Text);
            }
            else
            {
                alumno = new NoSocio(0, documento, txtNombre.Text, txtApellido.Text, DateTime.Today, chkAptoFisico.Checked, cmbActividad.Text);
            };
            if(DatosAlumno.ExisteAlumno(alumno))
            {
                MessageBox.Show(
                    "Ya existe un alumno con el mismo documento",
                    "Error al crear nuevo alumno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                btnLimpiar_Click(this, e);
            }
            else
            {
                DatosAlumno.CrearAlumno(alumno);
                MessageBox.Show(
                    "Alumno creado con éxito!",
                    "Crear nuevo alumno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            btnLimpiar_Click(this, e);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            chkSocio.Checked = false;
            chkAptoFisico.Checked= false;
            cmbActividad.Text = "";
            txtNombre.Focus();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmInscribirPostulante_Load(object sender, EventArgs e)
        {
            cmbActividad.Items.Add("Futbol");
            cmbActividad.Items.Add("Basquet");
            cmbActividad.Items.Add("Gimnasio");
            cmbActividad.Items.Add("Natacion");
            cmbActividad.SelectedIndex = 0;
        }
    }
}