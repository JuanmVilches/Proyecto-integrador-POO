using Proyecto_integrador_club_deportivo.Datos;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmPago : Form
    {
        int identificador;
        int documento;
        bool esSocio;
        int precio;
        DateTime inicio = DateTime.Today;
        DateTime fin;
        public frmPago(bool esSocio, int documento, string nombre, int identificador)
        {
            InitializeComponent();
            this.documento = documento;
            this.identificador = identificador;
            this.esSocio = esSocio;
            if (esSocio)
            {
                precio = 30000;
            } 
            else
            {
                precio = 5000;
            }
            lblPrecio.Text = "$" + precio.ToString();
            lblDocumento.Text = documento.ToString();
            lblNombre.Text = nombre;
            if (esSocio)
            {
                fin = inicio.AddMonths(1);
            }
            else
            {
                fin = inicio;
            }
            cmbCuotas.Items.Add("3 cuotas de: " + "$" + precio / 3);
            cmbCuotas.Items.Add("6 cuotas de: " + "$" + precio / 6);
            cmbCuotas.Enabled = false;
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
            Pago pago = new Pago(inicio, fin, identificador);
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
    }
}