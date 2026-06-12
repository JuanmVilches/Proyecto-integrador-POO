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
    public partial class frmInscribirPostulante : Form
    {
        public frmInscribirPostulante()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDocumento.Text, out int documento))
            {
                MessageBox.Show("Ingrese un documento válido");
                return;
            }
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos para registrar un alumno");
                return;
            }

            Alumno alumno = new Alumno(0, int.Parse(txtDocumento.Text), txtNombre.Text, txtApellido.Text, chkSocio.Checked, chkAptoFisico.Checked, cmbActividad.Text);

            // FALTA LÓGICA DE DATOSALUMNOS
            DatosAlumno.CrearAlumno(alumno);

            MessageBox.Show("Alumno creado con éxito!");
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            chkSocio.Checked = false;
            chkAptoFisico.Checked = false;
            cmbActividad.Text = "";

            txtNombre.Focus();
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
