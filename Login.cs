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
            string contraseñalog = passText.Text;
            if (Usuario.validarUsuario(usuarioLog, contraseñalog))
            {
                MessageBox.Show("¡Bienvenido!");
                Menu menuPrincipal = new Menu();
                menuPrincipal.Show();
                userText.Clear();
                passText.Clear();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto.");
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
    }
}