
namespace proyecto_bases
{
    partial class agregarVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarVacaciones));
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBuscarCargo = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.tablaAgregarVacaciones = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAgregarVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(321, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agregar Vacaciones";
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(221, 80);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(106, 21);
            this.cbxCargo.TabIndex = 46;
            this.cbxCargo.SelectedIndexChanged += new System.EventHandler(this.cbxCargo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(62, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Buscar por Cargo:";
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Location = new System.Drawing.Point(221, 123);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(215, 20);
            this.dateFechaInicio.TabIndex = 47;
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.Location = new System.Drawing.Point(528, 124);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(213, 20);
            this.dateFechaFin.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(107, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(442, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha Fin:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(796, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
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
            this.btnClose.TabIndex = 55;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBuscarCargo
            // 
            this.btnBuscarCargo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCargo.BackgroundImage")));
            this.btnBuscarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCargo.FlatAppearance.BorderSize = 0;
            this.btnBuscarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCargo.Location = new System.Drawing.Point(333, 78);
            this.btnBuscarCargo.Name = "btnBuscarCargo";
            this.btnBuscarCargo.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarCargo.TabIndex = 57;
            this.btnBuscarCargo.UseVisualStyleBackColor = true;
            this.btnBuscarCargo.Click += new System.EventHandler(this.btnBuscarCargo_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(528, 81);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(181, 20);
            this.txt_nombre.TabIndex = 59;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(360, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Buscar por Nombre:";
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarNombre.BackgroundImage")));
            this.btnBuscarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarNombre.FlatAppearance.BorderSize = 0;
            this.btnBuscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNombre.Location = new System.Drawing.Point(715, 78);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarNombre.TabIndex = 60;
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // tablaAgregarVacaciones
            // 
            this.tablaAgregarVacaciones.AllowUserToAddRows = false;
            this.tablaAgregarVacaciones.AllowUserToDeleteRows = false;
            this.tablaAgregarVacaciones.AllowUserToResizeRows = false;
            this.tablaAgregarVacaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaAgregarVacaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaAgregarVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAgregarVacaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar});
            this.tablaAgregarVacaciones.Location = new System.Drawing.Point(48, 201);
            this.tablaAgregarVacaciones.Name = "tablaAgregarVacaciones";
            this.tablaAgregarVacaciones.ReadOnly = true;
            this.tablaAgregarVacaciones.RowHeadersWidth = 15;
            this.tablaAgregarVacaciones.RowTemplate.Height = 25;
            this.tablaAgregarVacaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAgregarVacaciones.Size = new System.Drawing.Size(831, 276);
            this.tablaAgregarVacaciones.TabIndex = 61;
            this.tablaAgregarVacaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAgregarVacaciones_CellContentClick);
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "";
            this.Agregar.Image = ((System.Drawing.Image)(resources.GetObject("Agregar.Image")));
            this.Agregar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Width = 40;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(221, 162);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(138, 24);
            this.txtIdentificacion.TabIndex = 62;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.White;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(365, 162);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(268, 24);
            this.txtNombreEmpleado.TabIndex = 63;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(639, 160);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(102, 31);
            this.btnAgregar.TabIndex = 64;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // agregarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.tablaAgregarVacaciones);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarCargo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFechaFin);
            this.Controls.Add(this.dateFechaInicio);
            this.Controls.Add(this.cbxCargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarVacaciones";
            this.Text = "vacacionesEmpleados";
            this.Load += new System.EventHandler(this.vacacionesEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAgregarVacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.DateTimePicker dateFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBuscarCargo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.DataGridView tablaAgregarVacaciones;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.DataGridViewImageColumn Agregar;
        private System.Windows.Forms.Button btnAgregar;
    }
}