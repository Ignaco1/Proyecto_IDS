namespace VISTA
{
    partial class Form_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inicio));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            txt_usuario = new TextBox();
            txt_contra = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            btn_acceder = new Button();
            lbl_contra = new LinkLabel();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_ver = new PictureBox();
            bnt_dejarVer = new PictureBox();
            label_error = new Label();
            pictureBox_error = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_ver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnt_dejarVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_error).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(35, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(177, 201);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Enabled = false;
            panel2.Location = new Point(288, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 1);
            panel2.TabIndex = 1;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.FromArgb(32, 30, 45);
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuario.ForeColor = SystemColors.AppWorkspace;
            txt_usuario.Location = new Point(288, 65);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(450, 20);
            txt_usuario.TabIndex = 1;
            txt_usuario.Text = "USUARIO";
            txt_usuario.Enter += txt_usuario_Enter;
            txt_usuario.Leave += txt_usuario_Leave;
            // 
            // txt_contra
            // 
            txt_contra.BackColor = Color.FromArgb(32, 30, 45);
            txt_contra.BorderStyle = BorderStyle.None;
            txt_contra.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contra.ForeColor = SystemColors.AppWorkspace;
            txt_contra.Location = new Point(288, 130);
            txt_contra.Name = "txt_contra";
            txt_contra.Size = new Size(450, 20);
            txt_contra.TabIndex = 2;
            txt_contra.Text = "CONTRASEÑA";
            txt_contra.Enter += txt_contra_Enter;
            txt_contra.Leave += txt_contra_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Enabled = false;
            panel3.Location = new Point(288, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 1);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(462, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // btn_acceder
            // 
            btn_acceder.BackColor = Color.FromArgb(40, 40, 40);
            btn_acceder.FlatAppearance.BorderSize = 0;
            btn_acceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_acceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_acceder.FlatStyle = FlatStyle.Flat;
            btn_acceder.ForeColor = Color.LightGray;
            btn_acceder.Location = new Point(288, 234);
            btn_acceder.Name = "btn_acceder";
            btn_acceder.Size = new Size(450, 40);
            btn_acceder.TabIndex = 3;
            btn_acceder.Text = "ACCEDER";
            btn_acceder.UseVisualStyleBackColor = false;
            btn_acceder.Click += btn_acceder_Click;
            // 
            // lbl_contra
            // 
            lbl_contra.ActiveLinkColor = Color.FromArgb(11, 7, 17);
            lbl_contra.AutoSize = true;
            lbl_contra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_contra.ForeColor = SystemColors.ControlText;
            lbl_contra.LinkColor = SystemColors.AppWorkspace;
            lbl_contra.Location = new Point(409, 294);
            lbl_contra.Name = "lbl_contra";
            lbl_contra.Size = new Size(204, 17);
            lbl_contra.TabIndex = 0;
            lbl_contra.TabStop = true;
            lbl_contra.Text = "¿Has olvidado tu contraseña?";
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(750, 0);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(30, 30);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(723, 0);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(30, 30);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // btn_ver
            // 
            btn_ver.Image = (Image)resources.GetObject("btn_ver.Image");
            btn_ver.Location = new Point(711, 127);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(27, 27);
            btn_ver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_ver.TabIndex = 9;
            btn_ver.TabStop = false;
            btn_ver.Click += btn_ver_Click;
            // 
            // bnt_dejarVer
            // 
            bnt_dejarVer.Image = (Image)resources.GetObject("bnt_dejarVer.Image");
            bnt_dejarVer.Location = new Point(711, 124);
            bnt_dejarVer.Name = "bnt_dejarVer";
            bnt_dejarVer.Size = new Size(31, 31);
            bnt_dejarVer.SizeMode = PictureBoxSizeMode.Zoom;
            bnt_dejarVer.TabIndex = 10;
            bnt_dejarVer.TabStop = false;
            bnt_dejarVer.Click += bnt_dejarVer_Click;
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_error.ForeColor = Color.DeepPink;
            label_error.Location = new Point(326, 171);
            label_error.Name = "label_error";
            label_error.Size = new Size(93, 17);
            label_error.TabIndex = 11;
            label_error.Text = "Mensaje error";
            // 
            // pictureBox_error
            // 
            pictureBox_error.Image = (Image)resources.GetObject("pictureBox_error.Image");
            pictureBox_error.Location = new Point(288, 163);
            pictureBox_error.Name = "pictureBox_error";
            pictureBox_error.Size = new Size(32, 31);
            pictureBox_error.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_error.TabIndex = 12;
            pictureBox_error.TabStop = false;
            // 
            // Form_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(780, 330);
            Controls.Add(pictureBox_error);
            Controls.Add(label_error);
            Controls.Add(bnt_dejarVer);
            Controls.Add(btn_ver);
            Controls.Add(btn_minimizar);
            Controls.Add(btn_cerrar);
            Controls.Add(lbl_contra);
            Controls.Add(btn_acceder);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(txt_contra);
            Controls.Add(txt_usuario);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_inicio";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_inicio";
            Load += Form_inicio_Load;
            MouseDown += Form_inicio_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_ver).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnt_dejarVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txt_usuario;
        private TextBox txt_contra;
        private Panel panel3;
        private Label label1;
        private Button btn_acceder;
        private LinkLabel lbl_contra;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private PictureBox pictureBox3;
        private PictureBox btn_ver;
        private PictureBox bnt_dejarVer;
        private Label label_error;
        private PictureBox pictureBox_error;
    }
}