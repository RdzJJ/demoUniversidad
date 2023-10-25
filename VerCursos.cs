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
    public partial class VerCursos : Form
    {
        public VerCursos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void verCursosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void actualizar_Click(object sender, EventArgs e)
        {
            verCursosListView.Items.Clear();
            StreamReader lector;

            lector = File.OpenText("C:\\Users\\JULIAN\\source\\repos\\demoUniversidad\\Datos\\matriculadas.txt");
            while (!lector.EndOfStream)
            {
                verCursosListView.Items.Add(lector.ReadLine());
            }
            lector.Close();
        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhoraCursos.Text = DateTime.Now.ToString("hh: mm:ss tt");
        }

        private void VerCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
