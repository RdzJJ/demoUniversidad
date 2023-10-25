namespace demoUniversidad
{
    partial class Menu_Administrador_
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
            label1 = new Label();
            agregarUserBtn = new Button();
            EliminarUserBtn = new Button();
            AgregarCursoBtn = new Button();
            cerrarSesionBtn = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            adminNameLbl = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 58);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido Admin!\r\n¿Qué deseas hacer hoy?\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // agregarUserBtn
            // 
            agregarUserBtn.BackColor = SystemColors.ControlLightLight;
            agregarUserBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            agregarUserBtn.Location = new Point(289, 157);
            agregarUserBtn.Name = "agregarUserBtn";
            agregarUserBtn.Size = new Size(207, 48);
            agregarUserBtn.TabIndex = 1;
            agregarUserBtn.Text = "Agregar Usuario";
            agregarUserBtn.UseVisualStyleBackColor = true;
            agregarUserBtn.Click += agregarUserBtn_Click;
            // 
            // EliminarUserBtn
            // 
            EliminarUserBtn.BackColor = SystemColors.ControlLightLight;
            EliminarUserBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EliminarUserBtn.Location = new Point(289, 211);
            EliminarUserBtn.Name = "EliminarUserBtn";
            EliminarUserBtn.Size = new Size(207, 48);
            EliminarUserBtn.TabIndex = 3;
            EliminarUserBtn.Text = "Eliminar Usuario";
            EliminarUserBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarCursoBtn
            // 
            AgregarCursoBtn.BackColor = SystemColors.ControlLightLight;
            AgregarCursoBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AgregarCursoBtn.Location = new Point(289, 265);
            AgregarCursoBtn.Name = "AgregarCursoBtn";
            AgregarCursoBtn.Size = new Size(207, 48);
            AgregarCursoBtn.TabIndex = 4;
            AgregarCursoBtn.Text = "Agregar Curso";
            AgregarCursoBtn.UseVisualStyleBackColor = true;
            // 
            // cerrarSesionBtn
            // 
            cerrarSesionBtn.BackColor = SystemColors.ControlLightLight;
            cerrarSesionBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cerrarSesionBtn.Location = new Point(289, 319);
            cerrarSesionBtn.Name = "cerrarSesionBtn";
            cerrarSesionBtn.Size = new Size(207, 48);
            cerrarSesionBtn.TabIndex = 5;
            cerrarSesionBtn.Text = "Cerrar Sesión";
            cerrarSesionBtn.UseVisualStyleBackColor = true;
            cerrarSesionBtn.Click += cerrarSesionBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveBorder;
            pictureBox1.Image = Properties.Resources._456212;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(adminNameLbl);
            panel1.Location = new Point(573, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 37);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // adminNameLbl
            // 
            adminNameLbl.AutoSize = true;
            adminNameLbl.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            adminNameLbl.Location = new Point(43, 10);
            adminNameLbl.Name = "adminNameLbl";
            adminNameLbl.Size = new Size(153, 16);
            adminNameLbl.TabIndex = 7;
            adminNameLbl.Text = "Nombre de Administrador";
            adminNameLbl.Click += adminNameLbl_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(-3, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 87);
            panel2.TabIndex = 8;
            // 
            // Menu_Administrador_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(cerrarSesionBtn);
            Controls.Add(AgregarCursoBtn);
            Controls.Add(EliminarUserBtn);
            Controls.Add(agregarUserBtn);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_Administrador_";
            Text = "Menu(Admin)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button agregarUserBtn;
        private Button EliminarUserBtn;
        private Button AgregarCursoBtn;
        private Button cerrarSesionBtn;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label adminNameLbl;
        private Panel panel2;
    }
}