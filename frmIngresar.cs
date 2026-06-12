using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Proyecto_integrador_club_deportivo.Datos;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmIngresar : Form
    {
        public static string UsuarioLogueado = string.Empty;
        public frmIngresar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtIngresarUsuario_Leave(object sender, EventArgs e)
        {
            if (txtIngresarUsuario.Text == "")
            {
                txtIngresarUsuario.Text = "Ingresar usuario";
            }
            ;
        }
        private void txtIngresarUsuario_Enter(object sender, EventArgs e)
        {
            if (txtIngresarUsuario.Text == "Ingresar usuario")
            {
                txtIngresarUsuario.Text = "";
            }
            ;
        }

        private void txtIngresarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtIngresarContraseña.Text == "Ingresar contraseña")
            {
                txtIngresarContraseña.Text = "";
                txtIngresarContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtIngresarContraseña_Leave(object sender, EventArgs e)
        {
            if (txtIngresarContraseña.Text == "")
            {
                txtIngresarContraseña.UseSystemPasswordChar = false;
                txtIngresarContraseña.Text = "Ingresar contraseña";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Datos.DatosUsuario dato = new Datos.DatosUsuario(); // variable que contiene todas las caracteristicas de la clase
            DataTable tablaLogin = dato.Log_Usu(txtIngresarUsuario.Text, txtIngresarContraseña.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // Guardamos el nombre del usuario
                UsuarioLogueado = txtIngresarUsuario.Text;
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso");
                // Abrir otro formulario
                frmMenu menu = new frmMenu();
                menu.Show();

                // Cerrar login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn =
                    Conexion.getInstancia().CrearConexion();

                cn.Open();

                MessageBox.Show("Conexión exitosa");

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
