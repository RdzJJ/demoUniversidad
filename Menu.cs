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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MatricularCursos matricular = new MatricularCursos();
            matricular.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerCursos verCursos = new VerCursos();
            verCursos.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void horaMenu_Tick(object sender, EventArgs e)
        {
            lblHoraMenu.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblHoraMenu_Click(object sender, EventArgs e)
        {

        }

        private void lblsaludo_Click(object sender, EventArgs e)
        {

        }
        public void setSaludo(string nombre)
        {
            lblsaludo.Text = nombre;
        }
    }
}
