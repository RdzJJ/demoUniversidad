using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace demoUniversidad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            estado = -1;
        }

        public static int estado;
        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            string usuarioLog = userText.Text;
            string contraseñalog = passText.Text;
            if (Usuario.validarUsuario(usuarioLog, contraseñalog))
            {
                MessageBox.Show("¡Bienvenido!", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Usuario.verificarRol();
                switch (estado)
                {
                    case 0:
                        Menu_Administrador_ menuAdmin = new Menu_Administrador_();
                        menuAdmin.setSaludo(Usuario.Bienvenido(usuarioLog));
                        menuAdmin.Show();
                        break;
                    case 1:
                        MessageBox.Show("¡Se ejecuta magicamente el menu de profe", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        estado = -1;
                        break;

                    case 2:
                        Menu menuPrincipal = new Menu();
                        menuPrincipal.setSaludo(Usuario.Bienvenido(usuarioLog));
                        menuPrincipal.Show();
                        estado = -1;
                        break;
                    default:
                        MessageBox.Show("Usuario sin rol asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }


                userText.Clear();
                passText.Clear();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto.", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userText.Clear();
                passText.Clear();
            }

        }

        private void hora_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void userText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}