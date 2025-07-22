namespace VISTA
{
    partial class Form_recuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_recuperarContraseña));
            panel_imagen = new Panel();
            pictureBox3 = new PictureBox();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            label1 = new Label();
            btn_aceptar = new Button();
            label2 = new Label();
            label3 = new Label();
            txt_usuario = new TextBox();
            txt_email = new TextBox();
            pictureBox_error = new PictureBox();
            label_error = new Label();
            panel_imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_error).BeginInit();
            SuspendLayout();
            // 
            // panel_imagen
            // 
            panel_imagen.BackColor = Color.FromArgb(11, 7, 17);
            panel_imagen.Controls.Add(pictureBox3);
            panel_imagen.Dock = DockStyle.Left;
            panel_imagen.Location = new Point(0, 0);
            panel_imagen.Name = "panel_imagen";
            panel_imagen.Size = new Size(227, 330);
            panel_imagen.TabIndex = 1;
            panel_imagen.MouseDown += panel_imagen_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(177, 201);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(749, 0);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(30, 30);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 8;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(722, 0);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(30, 30);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 9;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(332, -3);
            label1.Name = "label1";
            label1.Size = new Size(313, 33);
            label1.TabIndex = 10;
            label1.Text = "Recuperar Contraseña";
            label1.MouseDown += label1_MouseDown;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.FromArgb(40, 40, 40);
            btn_aceptar.FlatAppearance.BorderSize = 0;
            btn_aceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_aceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_aceptar.FlatStyle = FlatStyle.Flat;
            btn_aceptar.ForeColor = Color.LightGray;
            btn_aceptar.Location = new Point(282, 269);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(450, 40);
            btn_aceptar.TabIndex = 11;
            btn_aceptar.Text = "ACEPTAR";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(249, 90);
            label2.Name = "label2";
            label2.Size = new Size(115, 33);
            label2.TabIndex = 12;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(249, 161);
            label3.Name = "label3";
            label3.Size = new Size(92, 33);
            label3.TabIndex = 13;
            label3.Text = "Email:";
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.AppWorkspace;
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_usuario.ForeColor = Color.FromArgb(150, 43, 127);
            txt_usuario.Location = new Point(370, 101);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(303, 26);
            txt_usuario.TabIndex = 14;
            // 
            // txt_email
            // 
            txt_email.BackColor = SystemColors.AppWorkspace;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_email.ForeColor = Color.FromArgb(150, 43, 127);
            txt_email.Location = new Point(361, 172);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(332, 26);
            txt_email.TabIndex = 16;
            // 
            // pictureBox_error
            // 
            pictureBox_error.Image = (Image)resources.GetObject("pictureBox_error.Image");
            pictureBox_error.Location = new Point(270, 211);
            pictureBox_error.Name = "pictureBox_error";
            pictureBox_error.Size = new Size(32, 31);
            pictureBox_error.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_error.TabIndex = 18;
            pictureBox_error.TabStop = false;
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_error.ForeColor = Color.DeepPink;
            label_error.Location = new Point(308, 219);
            label_error.Name = "label_error";
            label_error.Size = new Size(93, 17);
            label_error.TabIndex = 17;
            label_error.Text = "Mensaje error";
            // 
            // Form_recuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(780, 330);
            Controls.Add(pictureBox_error);
            Controls.Add(label_error);
            Controls.Add(txt_email);
            Controls.Add(txt_usuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_aceptar);
            Controls.Add(label1);
            Controls.Add(btn_minimizar);
            Controls.Add(btn_cerrar);
            Controls.Add(panel_imagen);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_recuperarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_recuperarContraseña";
            Load += Form_recuperarContraseña_Load_1;
            MouseDown += Form_recuperarContraseña_MouseDown;
            panel_imagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_imagen;
        private PictureBox pictureBox3;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private Label label1;
        private Button btn_aceptar;
        private Label label2;
        private Label label3;
        private TextBox txt_usuario;
        private TextBox txt_email;
        private PictureBox pictureBox_error;
        private Label label_error;
    }
}