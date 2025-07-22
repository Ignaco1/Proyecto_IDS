namespace VISTA
{
    partial class Form_gestionarPermisos
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
            panel_carga = new Panel();
            groupBox_carga = new GroupBox();
            txt_nombre = new TextBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            label1 = new Label();
            panel_lista_permisos = new Panel();
            groupBox_permisos = new GroupBox();
            dataGridView1 = new DataGridView();
            panel_botones = new Panel();
            btn_cerrar = new Button();
            btn_eliminarPermiso = new Button();
            btn_modificarPermiso = new Button();
            btn_crearPermiso = new Button();
            panel_carga.SuspendLayout();
            groupBox_carga.SuspendLayout();
            panel_lista_permisos.SuspendLayout();
            groupBox_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_botones.SuspendLayout();
            SuspendLayout();
            // 
            // panel_carga
            // 
            panel_carga.Controls.Add(groupBox_carga);
            panel_carga.Dock = DockStyle.Right;
            panel_carga.Location = new Point(852, 0);
            panel_carga.Name = "panel_carga";
            panel_carga.Size = new Size(259, 454);
            panel_carga.TabIndex = 0;
            // 
            // groupBox_carga
            // 
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Controls.Add(label1);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Size = new Size(259, 454);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(66, 89);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(181, 23);
            txt_nombre.TabIndex = 7;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.Location = new Point(161, 419);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_guardar.Location = new Point(6, 419);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 5;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 92);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // panel_lista_permisos
            // 
            panel_lista_permisos.Controls.Add(groupBox_permisos);
            panel_lista_permisos.Dock = DockStyle.Fill;
            panel_lista_permisos.Location = new Point(0, 0);
            panel_lista_permisos.Name = "panel_lista_permisos";
            panel_lista_permisos.Size = new Size(852, 454);
            panel_lista_permisos.TabIndex = 1;
            // 
            // groupBox_permisos
            // 
            groupBox_permisos.Controls.Add(dataGridView1);
            groupBox_permisos.Controls.Add(panel_botones);
            groupBox_permisos.Dock = DockStyle.Fill;
            groupBox_permisos.Location = new Point(0, 0);
            groupBox_permisos.Name = "groupBox_permisos";
            groupBox_permisos.Size = new Size(852, 454);
            groupBox_permisos.TabIndex = 0;
            groupBox_permisos.TabStop = false;
            groupBox_permisos.Text = "Lista de permisos";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(846, 381);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel_botones
            // 
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_eliminarPermiso);
            panel_botones.Controls.Add(btn_modificarPermiso);
            panel_botones.Controls.Add(btn_crearPermiso);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(3, 400);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(846, 51);
            panel_botones.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.Location = new Point(751, 19);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(92, 23);
            btn_cerrar.TabIndex = 4;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminarPermiso
            // 
            btn_eliminarPermiso.Location = new Point(245, 3);
            btn_eliminarPermiso.Name = "btn_eliminarPermiso";
            btn_eliminarPermiso.Size = new Size(114, 23);
            btn_eliminarPermiso.TabIndex = 2;
            btn_eliminarPermiso.Text = "Eliminar permiso";
            btn_eliminarPermiso.UseVisualStyleBackColor = true;
            btn_eliminarPermiso.Click += btn_eliminarPermiso_Click;
            // 
            // btn_modificarPermiso
            // 
            btn_modificarPermiso.Location = new Point(112, 3);
            btn_modificarPermiso.Name = "btn_modificarPermiso";
            btn_modificarPermiso.Size = new Size(113, 23);
            btn_modificarPermiso.TabIndex = 1;
            btn_modificarPermiso.Text = "Modificar permiso";
            btn_modificarPermiso.UseVisualStyleBackColor = true;
            btn_modificarPermiso.Click += btn_modificarPermiso_Click;
            // 
            // btn_crearPermiso
            // 
            btn_crearPermiso.Location = new Point(3, 3);
            btn_crearPermiso.Name = "btn_crearPermiso";
            btn_crearPermiso.Size = new Size(92, 23);
            btn_crearPermiso.TabIndex = 0;
            btn_crearPermiso.Text = "Crear permiso";
            btn_crearPermiso.UseVisualStyleBackColor = true;
            btn_crearPermiso.Click += btn_crearPermiso_Click;
            // 
            // Form_gestionarPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 454);
            Controls.Add(panel_lista_permisos);
            Controls.Add(panel_carga);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_gestionarPermisos";
            Text = "Form_gestionarPermisos";
            Load += Form_gestionarPermisos_Load;
            panel_carga.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            panel_lista_permisos.ResumeLayout(false);
            groupBox_permisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_botones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_carga;
        private GroupBox groupBox_carga;
        private Panel panel_lista_permisos;
        private GroupBox groupBox_permisos;
        private Panel panel_botones;
        private Button btn_cerrar;
        private Button btn_eliminarPermiso;
        private Button btn_modificarPermiso;
        private Button btn_crearPermiso;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txt_nombre;
        private Button btn_cancelar;
        private Button btn_guardar;
    }
}