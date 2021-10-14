
namespace proyecto_bases
{
    partial class agregarDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarDiagnostico));
            this.lblenfermedad = new System.Windows.Forms.Label();
            this.lbltxtmedico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.tablaMedico = new System.Windows.Forms.DataGridView();
            this.SelectMedico = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.tablaPaciente = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtIdentificacionP = new System.Windows.Forms.TextBox();
            this.cbxEnfermedad = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtIdentificacionM = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.Tablas = new System.Windows.Forms.Panel();
            this.panelObservaciones = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lbltxtpaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPaciente)).BeginInit();
            this.Tablas.SuspendLayout();
            this.panelObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblenfermedad
            // 
            this.lblenfermedad.AutoSize = true;
            this.lblenfermedad.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblenfermedad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblenfermedad.Location = new System.Drawing.Point(330, 96);
            this.lblenfermedad.Name = "lblenfermedad";
            this.lblenfermedad.Size = new System.Drawing.Size(117, 25);
            this.lblenfermedad.TabIndex = 59;
            this.lblenfermedad.Text = "Enfermedad: ";
            // 
            // lbltxtmedico
            // 
            this.lbltxtmedico.AutoSize = true;
            this.lbltxtmedico.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbltxtmedico.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltxtmedico.Location = new System.Drawing.Point(84, 69);
            this.lbltxtmedico.Name = "lbltxtmedico";
            this.lbltxtmedico.Size = new System.Drawing.Size(167, 25);
            this.lbltxtmedico.TabIndex = 54;
            this.lbltxtmedico.Text = "Buscar por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(291, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 37);
            this.label2.TabIndex = 53;
            this.label2.Text = "Agregar Diagnostico";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 33);
            this.btnClose.TabIndex = 61;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(61, 100);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(215, 20);
            this.txtNombreMedico.TabIndex = 63;
            this.txtNombreMedico.TextChanged += new System.EventHandler(this.txtNombreMedico_TextChanged);
            // 
            // tablaMedico
            // 
            this.tablaMedico.AllowUserToAddRows = false;
            this.tablaMedico.AllowUserToDeleteRows = false;
            this.tablaMedico.AllowUserToResizeRows = false;
            this.tablaMedico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectMedico});
            this.tablaMedico.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablaMedico.Location = new System.Drawing.Point(0, 0);
            this.tablaMedico.Name = "tablaMedico";
            this.tablaMedico.ReadOnly = true;
            this.tablaMedico.RowHeadersWidth = 15;
            this.tablaMedico.RowTemplate.Height = 25;
            this.tablaMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMedico.Size = new System.Drawing.Size(412, 268);
            this.tablaMedico.TabIndex = 64;
            this.tablaMedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMedico_CellContentClick);
            // 
            // SelectMedico
            // 
            this.SelectMedico.HeaderText = "";
            this.SelectMedico.Image = ((System.Drawing.Image)(resources.GetObject("SelectMedico.Image")));
            this.SelectMedico.Name = "SelectMedico";
            this.SelectMedico.ReadOnly = true;
            this.SelectMedico.Width = 17;
            // 
            // txtLimpiar
            // 
            this.txtLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtLimpiar.FlatAppearance.BorderSize = 0;
            this.txtLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtLimpiar.ForeColor = System.Drawing.Color.White;
            this.txtLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("txtLimpiar.Image")));
            this.txtLimpiar.Location = new System.Drawing.Point(827, 12);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(87, 35);
            this.txtLimpiar.TabIndex = 67;
            this.txtLimpiar.Text = "Limpiar";
            this.txtLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtLimpiar.UseVisualStyleBackColor = true;
            this.txtLimpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // tablaPaciente
            // 
            this.tablaPaciente.AllowUserToAddRows = false;
            this.tablaPaciente.AllowUserToDeleteRows = false;
            this.tablaPaciente.AllowUserToResizeRows = false;
            this.tablaPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.tablaPaciente.Dock = System.Windows.Forms.DockStyle.Right;
            this.tablaPaciente.Location = new System.Drawing.Point(456, 0);
            this.tablaPaciente.Name = "tablaPaciente";
            this.tablaPaciente.ReadOnly = true;
            this.tablaPaciente.RowHeadersWidth = 10;
            this.tablaPaciente.RowTemplate.Height = 25;
            this.tablaPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPaciente.Size = new System.Drawing.Size(412, 268);
            this.tablaPaciente.TabIndex = 70;
            this.tablaPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPaciente_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 17;
            // 
            // txtNombreP
            // 
            this.txtNombreP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreP.ForeColor = System.Drawing.Color.White;
            this.txtNombreP.Location = new System.Drawing.Point(8, 181);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.ReadOnly = true;
            this.txtNombreP.Size = new System.Drawing.Size(268, 20);
            this.txtNombreP.TabIndex = 71;
            this.txtNombreP.Visible = false;
            // 
            // txtIdentificacionP
            // 
            this.txtIdentificacionP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdentificacionP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacionP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIdentificacionP.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacionP.Location = new System.Drawing.Point(8, 145);
            this.txtIdentificacionP.Name = "txtIdentificacionP";
            this.txtIdentificacionP.ReadOnly = true;
            this.txtIdentificacionP.Size = new System.Drawing.Size(138, 20);
            this.txtIdentificacionP.TabIndex = 72;
            this.txtIdentificacionP.Visible = false;
            // 
            // cbxEnfermedad
            // 
            this.cbxEnfermedad.FormattingEnabled = true;
            this.cbxEnfermedad.Location = new System.Drawing.Point(441, 100);
            this.cbxEnfermedad.Name = "cbxEnfermedad";
            this.cbxEnfermedad.Size = new System.Drawing.Size(159, 21);
            this.cbxEnfermedad.TabIndex = 73;
            this.cbxEnfermedad.SelectedIndexChanged += new System.EventHandler(this.cbxEnfermedad_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(777, 480);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(102, 31);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreM
            // 
            this.txtNombreM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreM.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreM.ForeColor = System.Drawing.Color.White;
            this.txtNombreM.Location = new System.Drawing.Point(9, 62);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.ReadOnly = true;
            this.txtNombreM.Size = new System.Drawing.Size(268, 20);
            this.txtNombreM.TabIndex = 75;
            this.txtNombreM.Visible = false;
            // 
            // txtIdentificacionM
            // 
            this.txtIdentificacionM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdentificacionM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacionM.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIdentificacionM.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacionM.Location = new System.Drawing.Point(8, 33);
            this.txtIdentificacionM.Name = "txtIdentificacionM";
            this.txtIdentificacionM.ReadOnly = true;
            this.txtIdentificacionM.Size = new System.Drawing.Size(138, 20);
            this.txtIdentificacionM.TabIndex = 74;
            this.txtIdentificacionM.Visible = false;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblObservaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.lblObservaciones.Location = new System.Drawing.Point(324, 31);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(137, 25);
            this.lblObservaciones.TabIndex = 78;
            this.lblObservaciones.Text = "Observaciones: ";
            // 
            // Tablas
            // 
            this.Tablas.Controls.Add(this.tablaMedico);
            this.Tablas.Controls.Add(this.tablaPaciente);
            this.Tablas.Location = new System.Drawing.Point(30, 165);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(868, 268);
            this.Tablas.TabIndex = 79;
            // 
            // panelObservaciones
            // 
            this.panelObservaciones.Controls.Add(this.label3);
            this.panelObservaciones.Controls.Add(this.label1);
            this.panelObservaciones.Controls.Add(this.txtObservaciones);
            this.panelObservaciones.Controls.Add(this.lblObservaciones);
            this.panelObservaciones.Controls.Add(this.txtNombreM);
            this.panelObservaciones.Controls.Add(this.txtIdentificacionM);
            this.panelObservaciones.Controls.Add(this.txtIdentificacionP);
            this.panelObservaciones.Controls.Add(this.txtNombreP);
            this.panelObservaciones.Location = new System.Drawing.Point(52, 163);
            this.panelObservaciones.Name = "panelObservaciones";
            this.panelObservaciones.Size = new System.Drawing.Size(827, 289);
            this.panelObservaciones.TabIndex = 79;
            this.panelObservaciones.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "Medico:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtObservaciones.Location = new System.Drawing.Point(467, 0);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(360, 289);
            this.txtObservaciones.TabIndex = 79;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(647, 480);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeleccionar.Size = new System.Drawing.Size(124, 31);
            this.btnSeleccionar.TabIndex = 80;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblMedicos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMedicos.Location = new System.Drawing.Point(25, 134);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(83, 25);
            this.lblMedicos.TabIndex = 71;
            this.lblMedicos.Text = "Medicos:";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPacientes.Location = new System.Drawing.Point(481, 132);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(80, 25);
            this.lblPacientes.TabIndex = 81;
            this.lblPacientes.Text = "Paciente:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(513, 101);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(215, 20);
            this.txtNombrePaciente.TabIndex = 83;
            this.txtNombrePaciente.TextChanged += new System.EventHandler(this.txtNombrePaciente_TextChanged);
            // 
            // lbltxtpaciente
            // 
            this.lbltxtpaciente.AutoSize = true;
            this.lbltxtpaciente.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbltxtpaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltxtpaciente.Location = new System.Drawing.Point(536, 70);
            this.lbltxtpaciente.Name = "lbltxtpaciente";
            this.lbltxtpaciente.Size = new System.Drawing.Size(167, 25);
            this.lbltxtpaciente.TabIndex = 82;
            this.lbltxtpaciente.Text = "Buscar por Nombre";
            // 
            // agregarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.panelObservaciones);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lbltxtpaciente);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxEnfermedad);
            this.Controls.Add(this.txtLimpiar);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblenfermedad);
            this.Controls.Add(this.lbltxtmedico);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarDiagnostico";
            this.Text = "agregarDiagnostico";
            this.Load += new System.EventHandler(this.sustitucionesEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPaciente)).EndInit();
            this.Tablas.ResumeLayout(false);
            this.panelObservaciones.ResumeLayout(false);
            this.panelObservaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblenfermedad;
        private System.Windows.Forms.Label lbltxtmedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.DataGridView tablaMedico;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.DataGridView tablaPaciente;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtIdentificacionP;
        private System.Windows.Forms.ComboBox cbxEnfermedad;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtIdentificacionM;
        private System.Windows.Forms.DataGridViewImageColumn SelectMedico;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Panel Tablas;
        private System.Windows.Forms.Panel panelObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lbltxtpaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}