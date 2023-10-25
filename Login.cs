using System.Runtime.CompilerServices;

namespace demoUniversidad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            string usuarioLog = userText.Text;
            string contrase�alog = passText.Text;
            if (Usuario.validarUsuario(usuarioLog, contrase�alog))
            {

                MessageBox.Show("�Bienvenido!", "Validaci�n exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int rol;
                rol = Usuario.verificarRol();
                switch (rol)
                {
                    case 0:
                        Menu_Administrador_ menuAdmin = new Menu_Administrador_();
                        menuAdmin.setSaludo(Usuario.Bienvenido(usuarioLog));
                        menuAdmin.Show();
                        break;
                    case 1:
                        MessageBox.Show("�Se ejecuta magicamente el menu de profe", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        Menu menuPrincipal = new Menu();
                        menuPrincipal.setSaludo(Usuario.Bienvenido(usuarioLog));
                        menuPrincipal.Show();
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
                MessageBox.Show("Usuario o contrase�a incorrecto.", "Validaci�n exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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