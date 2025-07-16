namespace VISTA
{
    partial class Form_asignarPermisos
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
            label2 = new Label();
            check_listaPermisos = new CheckedListBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            txt_nombre = new TextBox();
            label1 = new Label();
            panel_lista_permisos = new Panel();
            groupBox_grupos = new GroupBox();
            dataGridView1 = new DataGridView();
            panel_botones = new Panel();
            btn_cerrar = new Button();
            btn_asignarPermisos = new Button();
            btn_modificarPermisos = new Button();
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
            panel_carga.Location = new Point(916, 0);
            panel_carga.Name = "panel_carga";
            panel_carga.Size = new Size(259, 643);
            panel_carga.TabIndex = 2;
            // 
            // groupBox_carga
            // 
            groupBox_carga.Controls.Add(label2);
            groupBox_carga.Controls.Add(check_listaPermisos);
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(label1);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Size = new Size(259, 643);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 116);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Permisos:";
            // 
            // check_listaPermisos
            // 
            check_listaPermisos.FormattingEnabled = true;
            check_listaPermisos.Location = new Point(101, 116);
            check_listaPermisos.Name = "check_listaPermisos";
            check_listaPermisos.Size = new Size(146, 364);
            check_listaPermisos.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.Location = new Point(155, 608);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_guardar.Location = new Point(6, 608);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 8;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(101, 67);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(146, 23);
            txt_nombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre grupo:";
            // 
            // panel_lista_permisos
            // 
            panel_lista_permisos.Controls.Add(groupBox_grupos);
            panel_lista_permisos.Dock = DockStyle.Fill;
            panel_lista_permisos.Location = new Point(0, 0);
            panel_lista_permisos.Name = "panel_lista_permisos";
            panel_lista_permisos.Size = new Size(916, 643);
            panel_lista_permisos.TabIndex = 3;
            // 
            // groupBox_grupos
            // 
            groupBox_grupos.Controls.Add(dataGridView1);
            groupBox_grupos.Controls.Add(panel_botones);
            groupBox_grupos.Dock = DockStyle.Fill;
            groupBox_grupos.Location = new Point(0, 0);
            groupBox_grupos.Name = "groupBox_grupos";
            groupBox_grupos.Size = new Size(916, 643);
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
            dataGridView1.Size = new Size(910, 570);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel_botones
            // 
            panel_botones.Controls.Add(btn_modificarPermisos);
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_asignarPermisos);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(3, 589);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(910, 51);
            panel_botones.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.Location = new Point(815, 19);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(92, 23);
            btn_cerrar.TabIndex = 5;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_asignarPermisos
            // 
            btn_asignarPermisos.Location = new Point(9, 6);
            btn_asignarPermisos.Name = "btn_asignarPermisos";
            btn_asignarPermisos.Size = new Size(114, 23);
            btn_asignarPermisos.TabIndex = 0;
            btn_asignarPermisos.Text = "Asignar permisos";
            btn_asignarPermisos.UseVisualStyleBackColor = true;
            btn_asignarPermisos.Click += btn_asignarPermisos_Click;
            // 
            // btn_modificarPermisos
            // 
            btn_modificarPermisos.Location = new Point(140, 6);
            btn_modificarPermisos.Name = "btn_modificarPermisos";
            btn_modificarPermisos.Size = new Size(125, 23);
            btn_modificarPermisos.TabIndex = 6;
            btn_modificarPermisos.Text = "Modificar permisos";
            btn_modificarPermisos.UseVisualStyleBackColor = true;
            btn_modificarPermisos.Click += btn_modificarPermisos_Click;
            // 
            // Form_asignarPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 643);
            Controls.Add(panel_lista_permisos);
            Controls.Add(panel_carga);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_asignarPermisos";
            Text = "Form_asignarPermisos";
            Load += Form_asignarPermisos_Load;
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
        private Button btn_asignarPermisos;
        private Button btn_cerrar;
        private Button btn_guardar;
        private Button btn_cancelar;
        private CheckedListBox check_listaPermisos;
        private Label label2;
        private Button btn_modificarPermisos;
    }
}