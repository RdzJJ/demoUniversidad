namespace demoUniversidad
{
    partial class VerCursos
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
            verCursosListView = new ListView();
            gobackBtn = new Button();
            actualizar = new Button();
            label1 = new Label();
            lblhoraCursos = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // verCursosListView
            // 
            verCursosListView.Location = new Point(143, 172);
            verCursosListView.Name = "verCursosListView";
            verCursosListView.Size = new Size(514, 201);
            verCursosListView.TabIndex = 0;
            verCursosListView.UseCompatibleStateImageBehavior = false;
            verCursosListView.SelectedIndexChanged += verCursosListView_SelectedIndexChanged;
            // 
            // gobackBtn
            // 
            gobackBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gobackBtn.Location = new Point(143, 143);
            gobackBtn.Name = "gobackBtn";
            gobackBtn.Size = new Size(136, 23);
            gobackBtn.TabIndex = 1;
            gobackBtn.Text = "Ir a Menú Principal";
            gobackBtn.UseVisualStyleBackColor = true;
            gobackBtn.Click += gobackBtn_Click;
            // 
            // actualizar
            // 
            actualizar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            actualizar.Location = new Point(551, 143);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(106, 23);
            actualizar.TabIndex = 2;
            actualizar.Text = "Actualizar";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(187, 39);
            label1.Name = "label1";
            label1.Size = new Size(434, 29);
            label1.TabIndex = 3;
            label1.Text = "¡Aquí están tus cursos matriculados!\r\n";
            label1.Click += label1_Click;
            // 
            // lblhoraCursos
            // 
            lblhoraCursos.AutoSize = true;
            lblhoraCursos.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblhoraCursos.Location = new Point(652, 419);
            lblhoraCursos.Name = "lblhoraCursos";
            lblhoraCursos.Size = new Size(37, 15);
            lblhoraCursos.TabIndex = 4;
            lblhoraCursos.Text = "Hora:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // VerCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblhoraCursos);
            Controls.Add(label1);
            Controls.Add(actualizar);
            Controls.Add(gobackBtn);
            Controls.Add(verCursosListView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerCursos";
            Text = "Cursos";
            Load += VerCursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView verCursosListView;
        private Button gobackBtn;
        private Button actualizar;
        private Label label1;
        private Label lblhoraCursos;
        private System.Windows.Forms.Timer timer1;
    }
}