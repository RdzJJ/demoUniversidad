using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace demoUniversidad
{
    public partial class MatricularCursos : Form
    {
        List<string> listaDeCursos = new List<string>();
        public MatricularCursos()
        {
            InitializeComponent();
            this.CenterToScreen();
            listView1.View = View.List;
        }


        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Add(comboBox1.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("No seleccionaste ningún curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void matricular_Click(object sender, EventArgs e)
        {
            listaDeCursos.Clear();
            foreach (ListViewItem item in listView1.Items)
            {
                listaDeCursos.Add(item.Text);
            }

            if (listaDeCursos.Count == 0)
            {
                MessageBox.Show("Recuerda seleccionar las materias y darle al botón Agregar", "No matriculaste ninguna materia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string elementosComoCadena = string.Join(Environment.NewLine, listaDeCursos);
                DialogResult result = MessageBox.Show("¿Estas seguro(a) de que quieres matricular los siguientes cursos?:\n" + elementosComoCadena, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StreamReader lector;
                    lector = File.OpenText(@"C:\Users\JULIAN\source\repos\demoUniversidad\Datos\matriculadas.txt");
                    if (lector == null)
                    {
                        MessageBox.Show("Prueba");
                    }
                    else
                    {
                        lector.Close();
                        MessageBox.Show("¡Tu matrícula ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StreamWriter sw = new StreamWriter(@"C:\Users\JULIAN\source\repos\demoUniversidad\Datos\matriculadas.txt", true);
                        sw.WriteLine(elementosComoCadena);
                        sw.Close();

                    }
                    lector.Close();
                }
            }
        }
        private void eliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void horaMatri_Tick_1(object sender, EventArgs e)
        {
            horaMa.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void btnRegrMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que quieres ir al menú principal?\n(Se borrarán todos los datos que no guardes)", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MatricularCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
