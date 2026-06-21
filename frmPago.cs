using Proyecto_integrador_club_deportivo.Clases;
using Proyecto_integrador_club_deportivo.Datos;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmPago : Form
    {
        Alumno alumno;
        DateTime inicio = DateTime.Today;
        DateTime fin;
        int precio = 0;
        internal frmPago(Alumno pagador)
        {
            InitializeComponent();
            alumno = pagador;
        }
        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cmbCuotas.Enabled = true;
        }
        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbCuotas.Enabled = false;
            cmbCuotas.Text = "";
        }
        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            if (!rbEfectivo.Checked && !rbTarjeta.Checked)
            {
                MessageBox.Show(
                    "Seleccione una forma de pago",
                    "Registro de pago",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (rbTarjeta.Checked && cmbCuotas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la cantidad de cuotas");
                return;
            }
            Pago pago = new Pago(inicio, fin, alumno.Identificador);
            DatosPago.RegistrarPago(pago);
            MessageBox.Show(
                "Pago registrado correctamente",
                "Registro de pago",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            if (alumno.EsSocio)
            {
                precio = 30000;
                fin = inicio.AddMonths(1);
            }
            else
            {
                precio = 5000;
                fin = inicio;
            }
            lblPrecio.Text = "$" + precio.ToString();
            lblDocumento.Text = alumno.Documento.ToString();
            lblNombre.Text = alumno.Nombre;
            cmbCuotas.Items.Add("3 cuotas de: $" + precio / 3);
            cmbCuotas.Items.Add("6 cuotas de: $" + precio / 6);
            cmbCuotas.Enabled = false;
        }
    }
}