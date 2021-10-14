
namespace proyecto_bases
{
    partial class sustitucionesEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sustitucionesEmpleados));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tablaSustituciones = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscarSustitucion = new System.Windows.Forms.Button();
            this.btnSustitucionesEmpleado = new System.Windows.Forms.Button();
            this.mostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSustituciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(644, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(409, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Fecha Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.Location = new System.Drawing.Point(574, 114);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(215, 20);
            this.dateFechaFin.TabIndex = 57;
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Location = new System.Drawing.Point(353, 114);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(215, 20);
            this.dateFechaInicio.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(103, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Nombre Empleado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(281, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 37);
            this.label2.TabIndex = 53;
            this.label2.Text = "Sustituciones de Empleados";
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
            this.txtNombre.Location = new System.Drawing.Point(83, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 20);
            this.txtNombre.TabIndex = 63;
            // 
            // tablaSustituciones
            // 
            this.tablaSustituciones.AllowUserToAddRows = false;
            this.tablaSustituciones.AllowUserToDeleteRows = false;
            this.tablaSustituciones.AllowUserToResizeRows = false;
            this.tablaSustituciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaSustituciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaSustituciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSustituciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.tablaSustituciones.Location = new System.Drawing.Point(158, 158);
            this.tablaSustituciones.Name = "tablaSustituciones";
            this.tablaSustituciones.ReadOnly = true;
            this.tablaSustituciones.RowHeadersWidth = 15;
            this.tablaSustituciones.RowTemplate.Height = 25;
            this.tablaSustituciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaSustituciones.Size = new System.Drawing.Size(610, 343);
            this.tablaSustituciones.TabIndex = 64;
            this.tablaSustituciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaSustituciones_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 40;
            // 
            // btnBuscarSustitucion
            // 
            this.btnBuscarSustitucion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarSustitucion.BackgroundImage")));
            this.btnBuscarSustitucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarSustitucion.FlatAppearance.BorderSize = 0;
            this.btnBuscarSustitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSustitucion.Location = new System.Drawing.Point(795, 114);
            this.btnBuscarSustitucion.Name = "btnBuscarSustitucion";
            this.btnBuscarSustitucion.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarSustitucion.TabIndex = 65;
            this.btnBuscarSustitucion.UseVisualStyleBackColor = true;
            this.btnBuscarSustitucion.Click += new System.EventHandler(this.btnBuscarSustitucion_Click);
            // 
            // btnSustitucionesEmpleado
            // 
            this.btnSustitucionesEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSustitucionesEmpleado.BackgroundImage")));
            this.btnSustitucionesEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSustitucionesEmpleado.FlatAppearance.BorderSize = 0;
            this.btnSustitucionesEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSustitucionesEmpleado.Location = new System.Drawing.Point(304, 115);
            this.btnSustitucionesEmpleado.Name = "btnSustitucionesEmpleado";
            this.btnSustitucionesEmpleado.Size = new System.Drawing.Size(26, 23);
            this.btnSustitucionesEmpleado.TabIndex = 66;
            this.btnSustitucionesEmpleado.UseVisualStyleBackColor = true;
            this.btnSustitucionesEmpleado.Click += new System.EventHandler(this.btnSustitucionesEmpleado_Click);
            // 
            // mostrarTodo
            // 
            this.mostrarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mostrarTodo.FlatAppearance.BorderSize = 0;
            this.mostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrarTodo.ForeColor = System.Drawing.Color.White;
            this.mostrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("mostrarTodo.Image")));
            this.mostrarTodo.Location = new System.Drawing.Point(795, 44);
            this.mostrarTodo.Name = "mostrarTodo";
            this.mostrarTodo.Size = new System.Drawing.Size(87, 35);
            this.mostrarTodo.TabIndex = 67;
            this.mostrarTodo.Text = "Todos";
            this.mostrarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mostrarTodo.UseVisualStyleBackColor = true;
            this.mostrarTodo.Click += new System.EventHandler(this.mostrarTodo_Click);
            // 
            // sustitucionesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.mostrarTodo);
            this.Controls.Add(this.btnSustitucionesEmpleado);
            this.Controls.Add(this.btnBuscarSustitucion);
            this.Controls.Add(this.tablaSustituciones);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFechaFin);
            this.Controls.Add(this.dateFechaInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sustitucionesEmpleados";
            this.Text = "sustitucionesEmpleados";
            this.Load += new System.EventHandler(this.sustitucionesEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSustituciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFechaFin;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView tablaSustituciones;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Button btnBuscarSustitucion;
        private System.Windows.Forms.Button btnSustitucionesEmpleado;
        private System.Windows.Forms.Button mostrarTodo;
    }
}