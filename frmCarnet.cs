using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmCarnet : Form
    {
        public frmCarnet(string nombre, string apellido, string documento, string actividad, bool socio)
        {
            InitializeComponent();

            lblNombre.Text = nombre + " " + apellido;
            lblActividad.Text = actividad;
            lblDocumento.Text = documento;
            if (socio)  lblTipo.Text = "SOCIO"; 
            else  lblTipo.Text = "NO SOCIO";
        }
    }
}
