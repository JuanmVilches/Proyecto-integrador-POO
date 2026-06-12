using Proyecto_integrador_club_deportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmVerInscriptos : Form
    {
        public frmVerInscriptos()
        {
            InitializeComponent();
        }

        private void CargarGrilla()
        {
            dvgInscriptos.DataSource =
                DatosAlumno.LeerAlumnos();

            if (!dvgInscriptos.Columns.Contains("Estado"))
            {
                DataGridViewTextBoxColumn estado =
                    new DataGridViewTextBoxColumn();

                estado.Name = "Estado";
                estado.HeaderText = "Estado";

                dvgInscriptos.Columns.Add(estado);
            }

            if (!dvgInscriptos.Columns.Contains("Ver Carnet"))
            {
                DataGridViewButtonColumn btnCarnet =
                    new DataGridViewButtonColumn();

                btnCarnet.Name = "Ver Carnet";
                btnCarnet.HeaderText = "Carnet";
                btnCarnet.Text = "Ver Carnet";
                btnCarnet.UseColumnTextForButtonValue = true;

                dvgInscriptos.Columns.Add(btnCarnet);
            }

            if (!dvgInscriptos.Columns.Contains("Pagar"))
            {
                DataGridViewButtonColumn btnPagar =
                    new DataGridViewButtonColumn();

                btnPagar.Name = "Pagar";
                btnPagar.HeaderText = "Cuota";
                btnPagar.Text = "Pagar";
                btnPagar.UseColumnTextForButtonValue = true;

                dvgInscriptos.Columns.Add(btnPagar);
            }

            dvgInscriptos.ReadOnly = true;
            dvgInscriptos.AllowUserToAddRows = false;
            dvgInscriptos.AllowUserToDeleteRows = false;

            dvgInscriptos.Columns["identificador"].Visible = false;

            dvgInscriptos.Columns["nombre"].HeaderText = "Nombre";
            dvgInscriptos.Columns["apellido"].HeaderText = "Apellido";
            dvgInscriptos.Columns["documento"].HeaderText = "Documento";
            dvgInscriptos.Columns["esSocio"].HeaderText = "Socio";
            dvgInscriptos.Columns["apto_fisico"].HeaderText = "Apto Físico";
            dvgInscriptos.Columns["actividad"].HeaderText = "Actividad";
            dvgInscriptos.Columns["vencimiento"].HeaderText = "Vencimiento";

            dvgInscriptos.Columns["vencimiento"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            foreach (DataGridViewRow fila in dvgInscriptos.Rows)
            {
                object vencimiento =
                    fila.Cells["vencimiento"].Value;

                if (vencimiento == null ||
                    vencimiento == DBNull.Value)
                {
                    fila.Cells["Estado"].Value =
                        "Sin pagos";
                }
                else
                {
                    DateTime fecha =
                        Convert.ToDateTime(vencimiento);

                    fila.Cells["Estado"].Value =
                        fecha >= DateTime.Today
                        ? "Al día"
                        : "Vencido";
                }
            }
        }
        private void frmVerInscriptos_Load(object sender, EventArgs e)
        {

            //DataGridViewButtonColumn btnCarnet = new DataGridViewButtonColumn();
            //DataGridViewButtonColumn btnPagar = new DataGridViewButtonColumn();
            //DataGridViewTextBoxColumn estado = new DataGridViewTextBoxColumn();

            //btnPagar.Name = "Pagar";
            //btnPagar.HeaderText = "Cuota";
            //btnPagar.Text = "Pagar";
            //btnPagar.UseColumnTextForButtonValue = true;

            //estado.HeaderText = "Estado";
            //estado.Name = "Estado";
            //btnCarnet.Name = "Ver Carnet";
            //btnCarnet.Text = "Ver Carnet";
            //btnCarnet.HeaderText = "Carnet";
            //btnCarnet.UseColumnTextForButtonValue = true;
            CargarGrilla();

            //dvgInscriptos.ReadOnly = true;
            //dvgInscriptos.AllowUserToAddRows = false;
            //dvgInscriptos.AllowUserToDeleteRows = false;
            //dvgInscriptos.Columns["identificador"].Visible = false;
            //dvgInscriptos.Columns["nombre"].HeaderText = "Nombre";
            //dvgInscriptos.Columns["apellido"].HeaderText = "Apellido";
            //dvgInscriptos.Columns["documento"].HeaderText = "Documento";
            //dvgInscriptos.Columns["esSocio"].HeaderText = "Socio";
            //dvgInscriptos.Columns["apto_fisico"].HeaderText = "Apto Físico";
            //dvgInscriptos.Columns["actividad"].HeaderText = "Actividad";
            //dvgInscriptos.Columns["vencimiento"].HeaderText = "Vencimiento";
            //dvgInscriptos.Columns["vencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dvgInscriptos.Columns.Add(btnCarnet);
            //dvgInscriptos.Columns.Add(btnPagar);
            //dvgInscriptos.Columns.Add(estado);

        }
        private void dvgInscriptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgInscriptos.Columns["Ver Carnet"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dvgInscriptos.Rows[e.RowIndex];

                frmCarnet carnet =
                    new frmCarnet(
                        fila.Cells["nombre"].Value.ToString(),
                        fila.Cells["apellido"].Value.ToString(),
                        fila.Cells["documento"].Value.ToString(),
                        fila.Cells["actividad"].Value.ToString(),
                        Convert.ToBoolean(
                            fila.Cells["esSocio"].Value)
                    );

                carnet.ShowDialog();
            }
            if (e.ColumnIndex == dvgInscriptos.Columns["Pagar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dvgInscriptos.Rows[e.RowIndex];

                string nombre = fila.Cells["nombre"].Value.ToString() + fila.Cells["apellido"].Value.ToString();

                int identificador = Convert.ToInt32(fila.Cells["identificador"].Value);
                int documento = (Convert.ToInt32(fila.Cells["documento"].Value));

                bool esSocio =
                    Convert.ToBoolean(
                        fila.Cells["esSocio"].Value);

                string estadoPago = fila.Cells["Estado"].Value.ToString();
                if(estadoPago == "Al día")
                {
                    MessageBox.Show("La cuota se encuentra al día");
                    return;
                };

                if(estadoPago == "Vencido" || estadoPago == "Sin pagos")
                {
                    frmPago formularioPagos = new frmPago(esSocio, documento, nombre, identificador);
                    if (formularioPagos.ShowDialog() == DialogResult.OK)
                    {
                        CargarGrilla();
                    }
                }
            }
        }
    }
}
