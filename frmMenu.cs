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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + frmIngresar.UsuarioLogueado;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscribirPostulante inscribirPosulante = new frmInscribirPostulante();
            inscribirPosulante.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
        "¿Está seguro que desea salir?",
        "Confirmar salida",
           MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
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
