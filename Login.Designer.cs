namespace demoUniversidad
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            IngresarBtn = new Button();
            userText = new TextBox();
            passText = new TextBox();
            loginLb = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hora = new System.Windows.Forms.Timer(components);
            lblhora = new Label();
            buttonSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IngresarBtn
            // 
            IngresarBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            IngresarBtn.Location = new Point(393, 227);
            IngresarBtn.Margin = new Padding(3, 2, 3, 2);
            IngresarBtn.Name = "IngresarBtn";
            IngresarBtn.Size = new Size(97, 28);
            IngresarBtn.TabIndex = 0;
            IngresarBtn.Text = "Ingresar";
            IngresarBtn.UseVisualStyleBackColor = true;
            IngresarBtn.Click += IngresarBtn_Click;
            // 
            // userText
            // 
            userText.Location = new Point(441, 173);
            userText.Margin = new Padding(3, 2, 3, 2);
            userText.Name = "userText";
            userText.Size = new Size(132, 23);
            userText.TabIndex = 1;
            // 
            // passText
            // 
            passText.Location = new Point(441, 200);
            passText.Margin = new Padding(3, 2, 3, 2);
            passText.Name = "passText";
            passText.PasswordChar = '*';
            passText.Size = new Size(132, 23);
            passText.TabIndex = 2;
            // 
            // loginLb
            // 
            loginLb.AutoSize = true;
            loginLb.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginLb.Location = new Point(16, 48);
            loginLb.Name = "loginLb";
            loginLb.Size = new Size(672, 32);
            loginLb.TabIndex = 3;
            loginLb.Text = "¡Bienvenido(a) a nuestra Plataforma Universitaria!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(362, 172);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 4;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(337, 203);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 5;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(326, 136);
            label3.Name = "label3";
            label3.Size = new Size(277, 16);
            label3.TabIndex = 6;
            label3.Text = "Por favor, ingresa tus datos para iniciar sesión:";
            // 
            // hora
            // 
            hora.Enabled = true;
            hora.Tick += hora_Tick_1;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblhora.Location = new Point(601, 314);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(41, 16);
            lblhora.TabIndex = 7;
            lblhora.Text = "Hora:";
            lblhora.Click += lblhora_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalir.Location = new Point(496, 227);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(95, 28);
            buttonSalir.TabIndex = 9;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = Properties.Resources._4562121;
            pictureBox1.Location = new Point(55, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(693, 338);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSalir);
            Controls.Add(lblhora);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginLb);
            Controls.Add(passText);
            Controls.Add(userText);
            Controls.Add(IngresarBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IngresarBtn;
        private TextBox userText;
        private TextBox passText;
        private Label loginLb;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer hora;
        private Label lblhora;
        private Button buttonSalir;
        private PictureBox pictureBox1;
    }
}