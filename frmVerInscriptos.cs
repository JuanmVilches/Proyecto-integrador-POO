using Proyecto_integrador_club_deportivo.Clases;
using Proyecto_integrador_club_deportivo.Datos;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmVerInscriptos : Form
    {
        List<Alumno> alumnos = new List<Alumno>();
        public frmVerInscriptos()
        {
            InitializeComponent();
        }
        private void CargarGrilla()
        {
            List<string> ordenColumnas = ["Documento","Nombre","Apellido","EsSocio","Apto_fisico","Actividad","Vencimiento"];

            alumnos.Clear();
            alumnos = DatosAlumno.LeerAlumnos();
            dvgInscriptos.DataSource = alumnos;

            for (int i = 0; i < ordenColumnas.Count; i++)
            {
                dvgInscriptos.Columns[ordenColumnas[i]].DisplayIndex = i;
            }

            dvgInscriptos.Columns["Apto_fisico"].HeaderText = "Apto Fisico";
            dvgInscriptos.Columns["EsSocio"].HeaderText = "Socio";
            dvgInscriptos.Columns["Identificador"].Visible = false;

            if (!dvgInscriptos.Columns.Contains("estado"))
            {
                dvgInscriptos.Columns.Add("estado", "Estado");
            }
            foreach (DataGridViewRow r in dvgInscriptos.Rows)
            {
                r.Cells["estado"].Value = alumnos[r.Index].obtenerEstadoPago();
            }
            if (!dvgInscriptos.Columns.Contains("carnet"))
            {
                DataGridViewButtonColumn btnCarnet = new DataGridViewButtonColumn();
                btnCarnet.Name = "carnet";
                btnCarnet.HeaderText = "Carnet";
                btnCarnet.Text = "Ver Carnet";
                btnCarnet.UseColumnTextForButtonValue = true;
                dvgInscriptos.Columns.Add(btnCarnet);
            }
            if (!dvgInscriptos.Columns.Contains("pagar"))
            {
                DataGridViewButtonColumn btnPagar = new DataGridViewButtonColumn();
                btnPagar.Name = "pagar";
                btnPagar.HeaderText = "Cuota";
                btnPagar.Text = "Pagar";
                btnPagar.UseColumnTextForButtonValue = true;
                dvgInscriptos.Columns.Add(btnPagar);
            }
            dvgInscriptos.ReadOnly = true;
            dvgInscriptos.AllowUserToAddRows = false;
            dvgInscriptos.AllowUserToDeleteRows = false;
        }
        private void frmVerInscriptos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void dvgInscriptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgInscriptos.Columns["carnet"].Index && e.RowIndex >= 0)
            {
                frmCarnet carnet = new frmCarnet(alumnos[e.RowIndex]);
                carnet.ShowDialog();
            }
            if (e.ColumnIndex == dvgInscriptos.Columns["pagar"].Index && e.RowIndex >= 0)
            {
                if (alumnos[e.RowIndex].obtenerEstadoPago() == "Al día")
                {
                    MessageBox.Show(
                        "La cuota se encuentra al día",
                        "Pagar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                };
                if(alumnos[e.RowIndex].obtenerEstadoPago() == "Vencido" || alumnos[e.RowIndex].obtenerEstadoPago() == "Sin pagos")
                {
                    frmPago formularioPagos = new frmPago(alumnos[e.RowIndex]);
                    if (formularioPagos.ShowDialog() == DialogResult.OK)
                    {
                        CargarGrilla();
                    }
                }
            }
        }
    }
}