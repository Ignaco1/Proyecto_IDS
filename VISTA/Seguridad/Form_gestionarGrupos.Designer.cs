namespace VISTA
{
    partial class Form_gestionarGrupos
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
            btn_cancelar = new Button();
            btn_guardar = new Button();
            txt_nombre = new TextBox();
            label1 = new Label();
            panel_lista_permisos = new Panel();
            groupBox_grupos = new GroupBox();
            dataGridView1 = new DataGridView();
            panel_botones = new Panel();
            btn_cerrar = new Button();
            btn_eliminarGrupo = new Button();
            btn_modificarGrupo = new Button();
            btn_crearGrupo = new Button();
            panel_carga.SuspendLayout();
            groupBox_carga.SuspendLayout();
            panel_lista_permisos.SuspendLayout();
            groupBox_grupos.SuspendLayout();
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
            panel_carga.TabIndex = 1;
            // 
            // groupBox_carga
            // 
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(label1);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Size = new Size(259, 454);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.Location = new Point(155, 419);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_guardar.Location = new Point(3, 419);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 8;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(66, 118);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(181, 23);
            txt_nombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 121);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // panel_lista_permisos
            // 
            panel_lista_permisos.Controls.Add(groupBox_grupos);
            panel_lista_permisos.Dock = DockStyle.Fill;
            panel_lista_permisos.Location = new Point(0, 0);
            panel_lista_permisos.Name = "panel_lista_permisos";
            panel_lista_permisos.Size = new Size(852, 454);
            panel_lista_permisos.TabIndex = 2;
            // 
            // groupBox_grupos
            // 
            groupBox_grupos.Controls.Add(dataGridView1);
            groupBox_grupos.Controls.Add(panel_botones);
            groupBox_grupos.Dock = DockStyle.Fill;
            groupBox_grupos.Location = new Point(0, 0);
            groupBox_grupos.Name = "groupBox_grupos";
            groupBox_grupos.Size = new Size(852, 454);
            groupBox_grupos.TabIndex = 0;
            groupBox_grupos.TabStop = false;
            groupBox_grupos.Text = "Lista de grupos";
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
            panel_botones.Controls.Add(btn_eliminarGrupo);
            panel_botones.Controls.Add(btn_modificarGrupo);
            panel_botones.Controls.Add(btn_crearGrupo);
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
            btn_cerrar.TabIndex = 5;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminarGrupo
            // 
            btn_eliminarGrupo.Location = new Point(245, 3);
            btn_eliminarGrupo.Name = "btn_eliminarGrupo";
            btn_eliminarGrupo.Size = new Size(114, 23);
            btn_eliminarGrupo.TabIndex = 2;
            btn_eliminarGrupo.Text = "Eliminar grupo";
            btn_eliminarGrupo.UseVisualStyleBackColor = true;
            btn_eliminarGrupo.Click += btn_eliminarGrupo_Click;
            // 
            // btn_modificarGrupo
            // 
            btn_modificarGrupo.Location = new Point(112, 3);
            btn_modificarGrupo.Name = "btn_modificarGrupo";
            btn_modificarGrupo.Size = new Size(113, 23);
            btn_modificarGrupo.TabIndex = 1;
            btn_modificarGrupo.Text = "Modificar grupo";
            btn_modificarGrupo.UseVisualStyleBackColor = true;
            btn_modificarGrupo.Click += btn_modificarGrupo_Click;
            // 
            // btn_crearGrupo
            // 
            btn_crearGrupo.Location = new Point(3, 3);
            btn_crearGrupo.Name = "btn_crearGrupo";
            btn_crearGrupo.Size = new Size(92, 23);
            btn_crearGrupo.TabIndex = 0;
            btn_crearGrupo.Text = "Crear grupo";
            btn_crearGrupo.UseVisualStyleBackColor = true;
            btn_crearGrupo.Click += btn_crearGrupo_Click;
            // 
            // Form_gestionarGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 454);
            Controls.Add(panel_lista_permisos);
            Controls.Add(panel_carga);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_gestionarGrupos";
            Text = "Form_gestionarGrupos";
            Load += Form_gestionarGrupos_Load;
            panel_carga.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            panel_lista_permisos.ResumeLayout(false);
            groupBox_grupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_botones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_carga;
        private GroupBox groupBox_carga;
        private TextBox txt_nombre;
        private Label label1;
        private Panel panel_lista_permisos;
        private GroupBox groupBox_grupos;
        private DataGridView dataGridView1;
        private Panel panel_botones;
        private Button btn_eliminarGrupo;
        private Button btn_modificarGrupo;
        private Button btn_crearGrupo;
        private Button btn_guardar;
        private Button btn_cancelar;
        private Button btn_cerrar;
    }
}