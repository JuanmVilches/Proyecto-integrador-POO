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
    public partial class frmVencimientos : Form
    {
        public frmVencimientos()
        {
            InitializeComponent();
        }

        private void frmVencimientos_Load(object sender, EventArgs e)
        {
            dgvVencimientos.DataSource =
                DatosAlumno.LeerVencimientosHoy();

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
