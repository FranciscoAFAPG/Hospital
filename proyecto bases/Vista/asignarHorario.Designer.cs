
namespace proyecto_bases
{
    partial class asignarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(asignarHorario));
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tablaEmpleado = new System.Windows.Forms.DataGridView();
            this.SelectMedico = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtLimpiar = new System.Windows.Forms.Button();
            this.tablaHorario = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.tablaHorarioAsignado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHorarioAsignado)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(592, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Seleccionar Dia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(84, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Buscar por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(291, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 37);
            this.label2.TabIndex = 53;
            this.label2.Text = "Asignacion de Horarios";
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 20);
            this.txtNombre.TabIndex = 63;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // tablaEmpleado
            // 
            this.tablaEmpleado.AllowUserToAddRows = false;
            this.tablaEmpleado.AllowUserToDeleteRows = false;
            this.tablaEmpleado.AllowUserToResizeRows = false;
            this.tablaEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectMedico});
            this.tablaEmpleado.Location = new System.Drawing.Point(49, 163);
            this.tablaEmpleado.Name = "tablaEmpleado";
            this.tablaEmpleado.ReadOnly = true;
            this.tablaEmpleado.RowHeadersWidth = 15;
            this.tablaEmpleado.RowTemplate.Height = 25;
            this.tablaEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEmpleado.Size = new System.Drawing.Size(520, 241);
            this.tablaEmpleado.TabIndex = 64;
            this.tablaEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmpleado_CellContentClick);
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
            this.txtLimpiar.Location = new System.Drawing.Point(795, 44);
            this.txtLimpiar.Name = "txtLimpiar";
            this.txtLimpiar.Size = new System.Drawing.Size(87, 35);
            this.txtLimpiar.TabIndex = 67;
            this.txtLimpiar.Text = "Limpiar";
            this.txtLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtLimpiar.UseVisualStyleBackColor = true;
            this.txtLimpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // tablaHorario
            // 
            this.tablaHorario.AllowUserToAddRows = false;
            this.tablaHorario.AllowUserToDeleteRows = false;
            this.tablaHorario.AllowUserToResizeRows = false;
            this.tablaHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.tablaHorario.Location = new System.Drawing.Point(584, 163);
            this.tablaHorario.Name = "tablaHorario";
            this.tablaHorario.ReadOnly = true;
            this.tablaHorario.RowHeadersWidth = 10;
            this.tablaHorario.RowTemplate.Height = 25;
            this.tablaHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaHorario.Size = new System.Drawing.Size(298, 241);
            this.tablaHorario.TabIndex = 70;
            this.tablaHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHorario_CellContentClick);
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
            // txtHoraFin
            // 
            this.txtHoraFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtHoraFin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraFin.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHoraFin.ForeColor = System.Drawing.Color.White;
            this.txtHoraFin.Location = new System.Drawing.Point(738, 137);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.ReadOnly = true;
            this.txtHoraFin.Size = new System.Drawing.Size(160, 20);
            this.txtHoraFin.TabIndex = 71;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtHoraInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraInicio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHoraInicio.ForeColor = System.Drawing.Color.White;
            this.txtHoraInicio.Location = new System.Drawing.Point(572, 137);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ReadOnly = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(160, 20);
            this.txtHoraInicio.TabIndex = 72;
            // 
            // cbxDia
            // 
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Location = new System.Drawing.Point(729, 99);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(133, 21);
            this.cbxDia.TabIndex = 73;
            this.cbxDia.SelectedIndexChanged += new System.EventHandler(this.cbxDia_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(467, 126);
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
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.White;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(193, 137);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(268, 20);
            this.txtNombreEmpleado.TabIndex = 75;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(49, 137);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(138, 20);
            this.txtIdentificacion.TabIndex = 74;
            // 
            // tablaHorarioAsignado
            // 
            this.tablaHorarioAsignado.AllowUserToAddRows = false;
            this.tablaHorarioAsignado.AllowUserToDeleteRows = false;
            this.tablaHorarioAsignado.AllowUserToResizeRows = false;
            this.tablaHorarioAsignado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaHorarioAsignado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaHorarioAsignado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHorarioAsignado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.tablaHorarioAsignado.Location = new System.Drawing.Point(237, 410);
            this.tablaHorarioAsignado.Name = "tablaHorarioAsignado";
            this.tablaHorarioAsignado.ReadOnly = true;
            this.tablaHorarioAsignado.RowHeadersWidth = 15;
            this.tablaHorarioAsignado.RowTemplate.Height = 25;
            this.tablaHorarioAsignado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaHorarioAsignado.Size = new System.Drawing.Size(456, 121);
            this.tablaHorarioAsignado.TabIndex = 77;
            this.tablaHorarioAsignado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHorarioAsignado_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(56, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Horario Asignado: ";
            // 
            // asignarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaHorarioAsignado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.cbxDia);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.tablaHorario);
            this.Controls.Add(this.txtLimpiar);
            this.Controls.Add(this.tablaEmpleado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "asignarHorario";
            this.Text = "asignarHorario";
            this.Load += new System.EventHandler(this.sustitucionesEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHorarioAsignado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView tablaEmpleado;
        private System.Windows.Forms.Button txtLimpiar;
        private System.Windows.Forms.DataGridView tablaHorario;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.DataGridViewImageColumn SelectMedico;
        private System.Windows.Forms.DataGridView tablaHorarioAsignado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}