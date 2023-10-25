namespace demoUniversidad
{
    partial class Menu
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
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            cerrarSesion = new Button();
            linkLabel3 = new LinkLabel();
            horaMenu = new System.Windows.Forms.Timer(components);
            lblHoraMenu = new Label();
            lblsaludo = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(309, 91);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 0;
            label1.Text = "Menú Principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(222, 21);
            label2.Name = "label2";
            label2.Size = new Size(389, 37);
            label2.TabIndex = 1;
            label2.Text = "Plataforma Universitaria";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(314, 124);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Matricular Cursos";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(314, 159);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(134, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Ver Cursos Matriculados";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // cerrarSesion
            // 
            cerrarSesion.BackColor = Color.AntiqueWhite;
            cerrarSesion.Location = new Point(557, 302);
            cerrarSesion.Margin = new Padding(3, 2, 3, 2);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(113, 28);
            cerrarSesion.TabIndex = 4;
            cerrarSesion.Text = "Cerrar Sesión";
            cerrarSesion.UseVisualStyleBackColor = true;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(314, 193);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(150, 15);
            linkLabel3.TabIndex = 5;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Ver Información de Usuario";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // horaMenu
            // 
            horaMenu.Enabled = true;
            horaMenu.Tick += horaMenu_Tick;
            // 
            // lblHoraMenu
            // 
            lblHoraMenu.AutoSize = true;
            lblHoraMenu.BackColor = Color.Gainsboro;
            lblHoraMenu.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoraMenu.ForeColor = Color.Black;
            lblHoraMenu.Location = new Point(12, 314);
            lblHoraMenu.Name = "lblHoraMenu";
            lblHoraMenu.Size = new Size(37, 16);
            lblHoraMenu.TabIndex = 6;
            lblHoraMenu.Text = "Hora";
            lblHoraMenu.Click += lblHoraMenu_Click;
            // 
            // lblsaludo
            // 
            lblsaludo.AutoSize = true;
            lblsaludo.BackColor = Color.Gainsboro;
            lblsaludo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblsaludo.ForeColor = Color.Black;
            lblsaludo.Location = new Point(8, 193);
            lblsaludo.Name = "lblsaludo";
            lblsaludo.Size = new Size(20, 18);
            lblsaludo.TabIndex = 7;
            lblsaludo.Text = "...";
            lblsaludo.Click += lblsaludo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Location = new Point(-4, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 55);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._229594622_4252981131436960_3360945037460184968_n;
            pictureBox1.Location = new Point(47, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(5, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 274);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(713, 341);
            Controls.Add(lblsaludo);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(lblHoraMenu);
            Controls.Add(linkLabel3);
            Controls.Add(cerrarSesion);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Menu(Estudiante)";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button cerrarSesion;
        private LinkLabel linkLabel3;
        private System.Windows.Forms.Timer horaMenu;
        private Label lblHoraMenu;
        private Label lblsaludo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}