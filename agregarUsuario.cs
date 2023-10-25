using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoUniversidad
{
    public partial class agregarUsuario : Form
    {
        public agregarUsuario()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void agregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void guardarUserBtn_Click(object sender, EventArgs e)
        {
            ingresarUsuario();
        }
        private void ingresarUsuario()
        {
            string nombre = nameTxtBox.Text;
            string username = userTxtBox.Text;
            string password = passTxtBox.Text;
            Random random = new Random();
            int id = random.Next(1, 10000);
            idTxtbox.Text = id.ToString();
            int rol = seleccionRolCombox.SelectedIndex;
            if (rol == -1)
            {
                MessageBox.Show("El campo Rol no puede ser null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string roltxt = "";
                switch (rol)
                {
                    case 0:
                        roltxt = "Administrador";
                        break;
                    case 1:
                        roltxt = "Docente";
                        break;
                    case 2:
                        roltxt = "Estudiante";
                        break;
                }
                DialogResult result = MessageBox.Show("¿Estás seguro que quieres registrar al siguiente usuario?+" +
                    "\nNombre: " + nombre +
                    "\nUsuario: " + username +
                    "\nContraseña: " + password +
                    "\nID: " + id +
                    "\nRol: " + roltxt, "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    nameTxtBox.Clear();
                    userTxtBox.Clear();
                    passTxtBox.Clear();
                    idTxtbox.Clear();
                    seleccionRolCombox.Items.Clear();
                    Usuario usuario = new Usuario(nombre, username, password, id, rol);
                    userList.agregar(usuario);
                }
            }
        }

        public void setName(string name)
        {
            nameTxtBox.Text = name;
        }

        private void backDatosBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
