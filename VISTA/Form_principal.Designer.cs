namespace VISTA
{
    partial class Form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            panel_menuLateral = new Panel();
            btn_informes = new Button();
            btn_cabañas_alquiler = new Button();
            panel_ABM = new Panel();
            btn_ABM_cabañas = new Button();
            btn_ABM_clientes = new Button();
            btn_ABM_usuarios = new Button();
            btn_ABM = new Button();
            panel_logo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_restaurar = new PictureBox();
            btn_maximizar = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            panel_forms = new Panel();
            pictureBox2 = new PictureBox();
            panel_menuLateral.SuspendLayout();
            panel_ABM.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            panel_forms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_menuLateral
            // 
            panel_menuLateral.AutoScroll = true;
            panel_menuLateral.BackColor = Color.FromArgb(11, 7, 17);
            panel_menuLateral.Controls.Add(btn_informes);
            panel_menuLateral.Controls.Add(btn_cabañas_alquiler);
            panel_menuLateral.Controls.Add(panel_ABM);
            panel_menuLateral.Controls.Add(btn_ABM);
            panel_menuLateral.Controls.Add(panel_logo);
            panel_menuLateral.Dock = DockStyle.Left;
            panel_menuLateral.Location = new Point(0, 0);
            panel_menuLateral.Name = "panel_menuLateral";
            panel_menuLateral.Size = new Size(250, 675);
            panel_menuLateral.TabIndex = 0;
            panel_menuLateral.MouseDown += panel_menuLateral_MouseDown;
            // 
            // btn_informes
            // 
            btn_informes.Dock = DockStyle.Top;
            btn_informes.FlatAppearance.BorderSize = 0;
            btn_informes.FlatStyle = FlatStyle.Flat;
            btn_informes.ForeColor = Color.Gainsboro;
            btn_informes.Location = new Point(0, 249);
            btn_informes.Name = "btn_informes";
            btn_informes.Padding = new Padding(10, 0, 0, 0);
            btn_informes.Size = new Size(250, 30);
            btn_informes.TabIndex = 4;
            btn_informes.Text = "Informes";
            btn_informes.TextAlign = ContentAlignment.MiddleLeft;
            btn_informes.UseVisualStyleBackColor = true;
            btn_informes.Click += btn_informes_Click;
            // 
            // btn_cabañas_alquiler
            // 
            btn_cabañas_alquiler.Dock = DockStyle.Top;
            btn_cabañas_alquiler.FlatAppearance.BorderSize = 0;
            btn_cabañas_alquiler.FlatStyle = FlatStyle.Flat;
            btn_cabañas_alquiler.ForeColor = Color.Gainsboro;
            btn_cabañas_alquiler.Location = new Point(0, 219);
            btn_cabañas_alquiler.Name = "btn_cabañas_alquiler";
            btn_cabañas_alquiler.Padding = new Padding(10, 0, 0, 0);
            btn_cabañas_alquiler.Size = new Size(250, 30);
            btn_cabañas_alquiler.TabIndex = 3;
            btn_cabañas_alquiler.Text = "Cabañas y alquiler";
            btn_cabañas_alquiler.TextAlign = ContentAlignment.MiddleLeft;
            btn_cabañas_alquiler.UseVisualStyleBackColor = true;
            btn_cabañas_alquiler.Click += btn_cabañas_alquiler_Click;
            // 
            // panel_ABM
            // 
            panel_ABM.BackColor = Color.FromArgb(40, 40, 40);
            panel_ABM.Controls.Add(btn_ABM_cabañas);
            panel_ABM.Controls.Add(btn_ABM_clientes);
            panel_ABM.Controls.Add(btn_ABM_usuarios);
            panel_ABM.Dock = DockStyle.Top;
            panel_ABM.Location = new Point(0, 130);
            panel_ABM.Name = "panel_ABM";
            panel_ABM.Size = new Size(250, 89);
            panel_ABM.TabIndex = 2;
            // 
            // btn_ABM_cabañas
            // 
            btn_ABM_cabañas.Dock = DockStyle.Top;
            btn_ABM_cabañas.FlatAppearance.BorderSize = 0;
            btn_ABM_cabañas.FlatStyle = FlatStyle.Flat;
            btn_ABM_cabañas.ForeColor = Color.Gainsboro;
            btn_ABM_cabañas.Location = new Point(0, 60);
            btn_ABM_cabañas.Name = "btn_ABM_cabañas";
            btn_ABM_cabañas.Padding = new Padding(35, 0, 0, 0);
            btn_ABM_cabañas.Size = new Size(250, 30);
            btn_ABM_cabañas.TabIndex = 2;
            btn_ABM_cabañas.Text = "ABM de Cabañas";
            btn_ABM_cabañas.TextAlign = ContentAlignment.MiddleLeft;
            btn_ABM_cabañas.UseVisualStyleBackColor = true;
            // 
            // btn_ABM_clientes
            // 
            btn_ABM_clientes.Dock = DockStyle.Top;
            btn_ABM_clientes.FlatAppearance.BorderSize = 0;
            btn_ABM_clientes.FlatStyle = FlatStyle.Flat;
            btn_ABM_clientes.ForeColor = Color.Gainsboro;
            btn_ABM_clientes.Location = new Point(0, 30);
            btn_ABM_clientes.Name = "btn_ABM_clientes";
            btn_ABM_clientes.Padding = new Padding(35, 0, 0, 0);
            btn_ABM_clientes.Size = new Size(250, 30);
            btn_ABM_clientes.TabIndex = 1;
            btn_ABM_clientes.Text = "ABM de Clientes";
            btn_ABM_clientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_ABM_clientes.UseVisualStyleBackColor = true;
            // 
            // btn_ABM_usuarios
            // 
            btn_ABM_usuarios.Dock = DockStyle.Top;
            btn_ABM_usuarios.FlatAppearance.BorderSize = 0;
            btn_ABM_usuarios.FlatStyle = FlatStyle.Flat;
            btn_ABM_usuarios.ForeColor = Color.Gainsboro;
            btn_ABM_usuarios.Location = new Point(0, 0);
            btn_ABM_usuarios.Name = "btn_ABM_usuarios";
            btn_ABM_usuarios.Padding = new Padding(35, 0, 0, 0);
            btn_ABM_usuarios.Size = new Size(250, 30);
            btn_ABM_usuarios.TabIndex = 0;
            btn_ABM_usuarios.Text = "ABM de Usuarios";
            btn_ABM_usuarios.TextAlign = ContentAlignment.MiddleLeft;
            btn_ABM_usuarios.UseVisualStyleBackColor = true;
            btn_ABM_usuarios.Click += btn_ABM_usuarios_Click;
            // 
            // btn_ABM
            // 
            btn_ABM.Dock = DockStyle.Top;
            btn_ABM.FlatAppearance.BorderSize = 0;
            btn_ABM.FlatStyle = FlatStyle.Flat;
            btn_ABM.ForeColor = Color.Gainsboro;
            btn_ABM.Location = new Point(0, 100);
            btn_ABM.Name = "btn_ABM";
            btn_ABM.Padding = new Padding(10, 0, 0, 0);
            btn_ABM.Size = new Size(250, 30);
            btn_ABM.TabIndex = 1;
            btn_ABM.Text = "ABM";
            btn_ABM.TextAlign = ContentAlignment.MiddleLeft;
            btn_ABM.UseVisualStyleBackColor = true;
            btn_ABM.Click += btn_ABM_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(pictureBox1);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(250, 100);
            panel_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(btn_restaurar);
            panel1.Controls.Add(btn_maximizar);
            panel1.Controls.Add(btn_minimizar);
            panel1.Controls.Add(btn_cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 34);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btn_restaurar
            // 
            btn_restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_restaurar.Image = (Image)resources.GetObject("btn_restaurar.Image");
            btn_restaurar.Location = new Point(940, 3);
            btn_restaurar.Name = "btn_restaurar";
            btn_restaurar.Size = new Size(30, 30);
            btn_restaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_restaurar.TabIndex = 11;
            btn_restaurar.TabStop = false;
            btn_restaurar.Click += btn_restaurar_Click;
            // 
            // btn_maximizar
            // 
            btn_maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_maximizar.Image = (Image)resources.GetObject("btn_maximizar.Image");
            btn_maximizar.Location = new Point(940, 3);
            btn_maximizar.Name = "btn_maximizar";
            btn_maximizar.Size = new Size(30, 30);
            btn_maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_maximizar.TabIndex = 10;
            btn_maximizar.TabStop = false;
            btn_maximizar.Click += btn_maximizar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(913, 3);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(30, 30);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 9;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click_1;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(967, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(30, 30);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 8;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click_1;
            // 
            // panel_forms
            // 
            panel_forms.BackColor = Color.FromArgb(32, 30, 45);
            panel_forms.Controls.Add(pictureBox2);
            panel_forms.Dock = DockStyle.Fill;
            panel_forms.Location = new Point(250, 34);
            panel_forms.Name = "panel_forms";
            panel_forms.Size = new Size(1000, 641);
            panel_forms.TabIndex = 2;
            panel_forms.MouseDown += panel_forms_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(341, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(335, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 675);
            Controls.Add(panel_forms);
            Controls.Add(panel1);
            Controls.Add(panel_menuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_principal";
            Load += Form_principal_Load;
            panel_menuLateral.ResumeLayout(false);
            panel_ABM.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            panel_forms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_menuLateral;
        private Panel panel_ABM;
        private Button btn_ABM;
        private Panel panel_logo;
        private Button btn_ABM_cabañas;
        private Button btn_ABM_clientes;
        private Button btn_ABM_usuarios;
        private Button btn_informes;
        private Button btn_cabañas_alquiler;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel_forms;
        private PictureBox pictureBox2;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private PictureBox btn_maximizar;
        private PictureBox btn_restaurar;
    }
}