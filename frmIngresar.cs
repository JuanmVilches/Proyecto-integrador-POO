using MySql.Data.MySqlClient;
using Proyecto_integrador_club_deportivo.Datos;
using System.Data;

namespace Proyecto_integrador_club_deportivo
{
    public partial class frmIngresar : Form
    {
        public static string UsuarioLogueado = string.Empty;
        public frmIngresar()
        {
            InitializeComponent();
            if (!Conexion.hayInstancia())
            {
                frmConexion datosConexion = new frmConexion();
                datosConexion.ShowDialog();
            }
        }
        private void txtIngresarUsuario_Leave(object sender, EventArgs e)
        {
            if (txtIngresarUsuario.Text == "")
            {
                txtIngresarUsuario.Text = "Ingresar usuario";
            };
        }
        private void txtIngresarUsuario_Enter(object sender, EventArgs e)
        {
            if (txtIngresarUsuario.Text == "Ingresar usuario")
            {
                txtIngresarUsuario.Text = "";
            };
        }
        private void txtIngresarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtIngresarContraseña.Text == "Ingresar contraseña")
            {
                txtIngresarContraseña.Text = "";
                txtIngresarContraseña.UseSystemPasswordChar = true;
            };
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
            if(DatosUsuario.Ingresar(txtIngresarUsuario.Text,txtIngresarContraseña.Text))
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                Hide();
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