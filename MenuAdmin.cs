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
    public partial class Menu_Administrador_ : Form
    {
        public Menu_Administrador_()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void setSaludo(string nombre)
        {
            adminNameLbl.Text = nombre;
        }

        private void agregarUserBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

        }
    }
}
