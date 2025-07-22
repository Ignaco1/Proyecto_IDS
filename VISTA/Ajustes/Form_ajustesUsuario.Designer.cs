namespace VISTA
{
    partial class Form_ajustesUsuario
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
            panel_botones = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btn_cambiarContra = new Button();
            btn_datos = new Button();
            panel1 = new Panel();
            btn_cerrar = new Button();
            panel_forms = new Panel();
            panel_botones.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_botones
            // 
            panel_botones.BackColor = SystemColors.Control;
            panel_botones.BorderStyle = BorderStyle.FixedSingle;
            panel_botones.Controls.Add(panel3);
            panel_botones.Controls.Add(panel2);
            panel_botones.Controls.Add(btn_cambiarContra);
            panel_botones.Controls.Add(btn_datos);
            panel_botones.Dock = DockStyle.Top;
            panel_botones.Location = new Point(0, 0);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(1164, 101);
            panel_botones.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(951, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 99);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 99);
            panel2.TabIndex = 6;
            // 
            // btn_cambiarContra
            // 
            btn_cambiarContra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cambiarContra.Location = new Point(818, 32);
            btn_cambiarContra.Name = "btn_cambiarContra";
            btn_cambiarContra.Size = new Size(126, 37);
            btn_cambiarContra.TabIndex = 5;
            btn_cambiarContra.Text = "Cambiar contraseña";
            btn_cambiarContra.UseVisualStyleBackColor = true;
            btn_cambiarContra.Click += btn_cambiarContra_Click;
            // 
            // btn_datos
            // 
            btn_datos.Location = new Point(217, 32);
            btn_datos.Name = "btn_datos";
            btn_datos.Size = new Size(126, 37);
            btn_datos.TabIndex = 4;
            btn_datos.Text = "Mis datos";
            btn_datos.UseVisualStyleBackColor = true;
            btn_datos.Click += btn_datos_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_cerrar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 614);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 51);
            panel1.TabIndex = 1;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.Location = new Point(1057, 15);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(94, 23);
            btn_cerrar.TabIndex = 1;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click_1;
            // 
            // panel_forms
            // 
            panel_forms.Dock = DockStyle.Fill;
            panel_forms.Location = new Point(0, 101);
            panel_forms.Name = "panel_forms";
            panel_forms.Size = new Size(1164, 513);
            panel_forms.TabIndex = 2;
            // 
            // Form_ajustesUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 665);
            Controls.Add(panel_forms);
            Controls.Add(panel1);
            Controls.Add(panel_botones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ajustesUsuario";
            Text = "Form_ajustesUsuario";
            Load += Form_ajustesUsuario_Load;
            panel_botones.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_botones;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btn_cambiarContra;
        private Button btn_datos;
        private Button btn_cerrar;
        private Panel panel_forms;
    }
}