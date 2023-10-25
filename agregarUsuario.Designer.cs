namespace demoUniversidad
{
    partial class agregarUsuario
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
            panel1 = new Panel();
            lblIngresarDatos = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nameTxtBox = new TextBox();
            passTxtBox = new TextBox();
            userTxtBox = new TextBox();
            idTxtbox = new TextBox();
            seleccionRolCombox = new ComboBox();
            backDatosBtn = new Button();
            guardarUserBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(lblIngresarDatos);
            panel1.Location = new Point(-2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 98);
            panel1.TabIndex = 0;
            // 
            // lblIngresarDatos
            // 
            lblIngresarDatos.AutoSize = true;
            lblIngresarDatos.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresarDatos.Location = new Point(172, 20);
            lblIngresarDatos.Name = "lblIngresarDatos";
            lblIngresarDatos.Size = new Size(418, 58);
            lblIngresarDatos.TabIndex = 9;
            lblIngresarDatos.Text = "Ingrese los datos del Usuario en el \r\nsiguiente formulario:\r\n";
            lblIngresarDatos.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 171);
            label1.Name = "label1";
            label1.Size = new Size(154, 19);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(160, 200);
            label2.Name = "label2";
            label2.Size = new Size(163, 19);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(219, 231);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(292, 263);
            label4.Name = "label4";
            label4.Size = new Size(31, 19);
            label4.TabIndex = 4;
            label4.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(170, 291);
            label5.Name = "label5";
            label5.Size = new Size(153, 19);
            label5.TabIndex = 5;
            label5.Text = "Seleccione un Rol:";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(329, 171);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(227, 23);
            nameTxtBox.TabIndex = 6;
            nameTxtBox.TextChanged += nameTxtBox_TextChanged;
            // 
            // passTxtBox
            // 
            passTxtBox.Location = new Point(329, 227);
            passTxtBox.Name = "passTxtBox";
            passTxtBox.PasswordChar = '*';
            passTxtBox.Size = new Size(227, 23);
            passTxtBox.TabIndex = 8;
            // 
            // userTxtBox
            // 
            userTxtBox.Location = new Point(329, 200);
            userTxtBox.Name = "userTxtBox";
            userTxtBox.Size = new Size(227, 23);
            userTxtBox.TabIndex = 7;
            // 
            // idTxtbox
            // 
            idTxtbox.AccessibleRole = AccessibleRole.None;
            idTxtbox.Location = new Point(329, 259);
            idTxtbox.Name = "idTxtbox";
            idTxtbox.ReadOnly = true;
            idTxtbox.Size = new Size(227, 23);
            idTxtbox.TabIndex = 9;
            // 
            // seleccionRolCombox
            // 
            seleccionRolCombox.FormattingEnabled = true;
            seleccionRolCombox.Items.AddRange(new object[] { "1. Administrador", "2. Docente", "3. Estudiante" });
            seleccionRolCombox.Location = new Point(329, 291);
            seleccionRolCombox.Name = "seleccionRolCombox";
            seleccionRolCombox.Size = new Size(227, 23);
            seleccionRolCombox.TabIndex = 10;
            // 
            // backDatosBtn
            // 
            backDatosBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            backDatosBtn.Location = new Point(12, 116);
            backDatosBtn.Name = "backDatosBtn";
            backDatosBtn.Size = new Size(128, 33);
            backDatosBtn.TabIndex = 11;
            backDatosBtn.Text = "Regresar al Menú";
            backDatosBtn.UseVisualStyleBackColor = true;
            backDatosBtn.Click += backDatosBtn_Click;
            // 
            // guardarUserBtn
            // 
            guardarUserBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guardarUserBtn.Location = new Point(366, 351);
            guardarUserBtn.Name = "guardarUserBtn";
            guardarUserBtn.Size = new Size(128, 33);
            guardarUserBtn.TabIndex = 12;
            guardarUserBtn.Text = "Guardar Usuario";
            guardarUserBtn.UseVisualStyleBackColor = true;
            guardarUserBtn.Click += guardarUserBtn_Click;
            // 
            // agregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarUserBtn);
            Controls.Add(backDatosBtn);
            Controls.Add(seleccionRolCombox);
            Controls.Add(idTxtbox);
            Controls.Add(passTxtBox);
            Controls.Add(userTxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "agregarUsuario";
            Text = "agregarUsuario";
            Load += agregarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblIngresarDatos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameTxtBox;
        private TextBox passTxtBox;
        private TextBox userTxtBox;
        private TextBox idTxtbox;
        private ComboBox seleccionRolCombox;
        private Button backDatosBtn;
        private Button guardarUserBtn;
    }
}