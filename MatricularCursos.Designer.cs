namespace demoUniversidad
{
    partial class MatricularCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            agregar = new Button();
            listView1 = new ListView();
            comboBox1 = new ComboBox();
            matricular = new Button();
            eliminar = new Button();
            horaMatri = new System.Windows.Forms.Timer(components);
            horaMa = new Label();
            btnRegrMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 35);
            label1.Name = "label1";
            label1.Size = new Size(430, 47);
            label1.TabIndex = 0;
            label1.Text = "Inscribir o Eliminar Cursos";
            label1.Click += label1_Click;
            // 
            // agregar
            // 
            agregar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            agregar.Location = new Point(145, 96);
            agregar.Margin = new Padding(3, 2, 3, 2);
            agregar.Name = "agregar";
            agregar.Size = new Size(84, 26);
            agregar.TabIndex = 2;
            agregar.Text = "AGREGAR";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(145, 143);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(384, 103);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "002334 - Paradigmas de Programación", "001345 - Arquitectura de Computadores", "003456 - Bases de Datos", "009071 - Humanismo y Cultura", "003194 - Futbol e historia", "001925 - Ofimatica", "008435 - Matematicas Operativas", "005935 - Mantenimiento de Computadores" });
            comboBox1.Location = new Point(257, 99);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // matricular
            // 
            matricular.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            matricular.Location = new Point(145, 250);
            matricular.Margin = new Padding(3, 2, 3, 2);
            matricular.Name = "matricular";
            matricular.Size = new Size(132, 26);
            matricular.TabIndex = 5;
            matricular.Text = "Matricular curso(s)";
            matricular.UseVisualStyleBackColor = true;
            matricular.Click += matricular_Click;
            // 
            // eliminar
            // 
            eliminar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            eliminar.Location = new Point(408, 254);
            eliminar.Margin = new Padding(3, 2, 3, 2);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(121, 22);
            eliminar.TabIndex = 6;
            eliminar.Text = "Eliminar Cursos";
            eliminar.UseVisualStyleBackColor = true;
            eliminar.Click += eliminar_Click;
            // 
            // horaMatri
            // 
            horaMatri.Enabled = true;
            horaMatri.Tick += horaMatri_Tick_1;
            // 
            // horaMa
            // 
            horaMa.AutoSize = true;
            horaMa.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            horaMa.Location = new Point(613, 309);
            horaMa.Name = "horaMa";
            horaMa.Size = new Size(34, 16);
            horaMa.TabIndex = 7;
            horaMa.Text = "Hora";
            // 
            // btnRegrMenu
            // 
            btnRegrMenu.BackColor = SystemColors.MenuBar;
            btnRegrMenu.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegrMenu.Location = new Point(27, 302);
            btnRegrMenu.Name = "btnRegrMenu";
            btnRegrMenu.Size = new Size(124, 23);
            btnRegrMenu.TabIndex = 8;
            btnRegrMenu.Text = "Ir a Menú Principal";
            btnRegrMenu.UseVisualStyleBackColor = false;
            btnRegrMenu.Click += btnRegrMenu_Click;
            // 
            // MatricularCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnRegrMenu);
            Controls.Add(horaMa);
            Controls.Add(eliminar);
            Controls.Add(matricular);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Controls.Add(agregar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MatricularCursos";
            Text = "MatricularCursos";
            Load += MatricularCursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button agregar;
        private ListView listView1;
        private ComboBox comboBox1;
        private Button matricular;
        private Button eliminar;
        private System.Windows.Forms.Timer horaMatri;
        private Label horaMa;
        private Button btnRegrMenu;
    }
}