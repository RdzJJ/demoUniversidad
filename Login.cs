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
            Validacion(usuarioLog, contrase�alog);

        }
        public bool Validacion(string usuario, string contrase�a)
        {
            if (usuario.Equals("admin") && contrase�a.Equals("123"))
            {
                MessageBox.Show("Bienvenido");
                Menu menuPrincipal = new Menu();
                menuPrincipal.Show();
                userText.Clear();
                passText.Clear();
                return true;

            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos ");
                userText.Clear();
                passText.Clear();
                return false;
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