
namespace proyecto_bases
{
    partial class empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empleados));
            this.label2 = new System.Windows.Forms.Label();
            this.Boton_crear_empleado = new System.Windows.Forms.Button();
            this.list_cargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_municipio_emp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefono_emp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_direccion_emp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_emp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_identificacion_emp = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.tablaEmpleado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(310, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Información Empleados";
            // 
            // Boton_crear_empleado
            // 
            this.Boton_crear_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Boton_crear_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_crear_empleado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_crear_empleado.Image = ((System.Drawing.Image)(resources.GetObject("Boton_crear_empleado.Image")));
            this.Boton_crear_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_crear_empleado.Location = new System.Drawing.Point(730, 63);
            this.Boton_crear_empleado.Name = "Boton_crear_empleado";
            this.Boton_crear_empleado.Size = new System.Drawing.Size(129, 37);
            this.Boton_crear_empleado.TabIndex = 32;
            this.Boton_crear_empleado.Text = "Agregar";
            this.Boton_crear_empleado.UseVisualStyleBackColor = false;
            this.Boton_crear_empleado.Click += new System.EventHandler(this.Boton_crear_empleado_Click);
            // 
            // list_cargo
            // 
            this.list_cargo.FormattingEnabled = true;
            this.list_cargo.Location = new System.Drawing.Point(468, 156);
            this.list_cargo.Name = "list_cargo";
            this.list_cargo.Size = new System.Drawing.Size(163, 21);
            this.list_cargo.TabIndex = 31;
            this.list_cargo.SelectedIndexChanged += new System.EventHandler(this.list_cargo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(362, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Municipio";
            // 
            // txt_municipio_emp
            // 
            this.txt_municipio_emp.Location = new System.Drawing.Point(468, 117);
            this.txt_municipio_emp.Name = "txt_municipio_emp";
            this.txt_municipio_emp.Size = new System.Drawing.Size(163, 20);
            this.txt_municipio_emp.TabIndex = 27;
            this.txt_municipio_emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_municipio_emp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(392, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cargo";
            // 
            // txt_telefono_emp
            // 
            this.txt_telefono_emp.Location = new System.Drawing.Point(468, 78);
            this.txt_telefono_emp.Name = "txt_telefono_emp";
            this.txt_telefono_emp.Size = new System.Drawing.Size(163, 20);
            this.txt_telefono_emp.TabIndex = 25;
            this.txt_telefono_emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_emp_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(373, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefono";
            // 
            // txt_direccion_emp
            // 
            this.txt_direccion_emp.Location = new System.Drawing.Point(160, 157);
            this.txt_direccion_emp.Name = "txt_direccion_emp";
            this.txt_direccion_emp.Size = new System.Drawing.Size(163, 20);
            this.txt_direccion_emp.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(69, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dirección";
            // 
            // txt_nombre_emp
            // 
            this.txt_nombre_emp.Location = new System.Drawing.Point(160, 115);
            this.txt_nombre_emp.Name = "txt_nombre_emp";
            this.txt_nombre_emp.Size = new System.Drawing.Size(163, 20);
            this.txt_nombre_emp.TabIndex = 21;
            this.txt_nombre_emp.TextChanged += new System.EventHandler(this.txt_nombre_emp_TextChanged);
            this.txt_nombre_emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_emp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(76, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // txt_identificacion_emp
            // 
            this.txt_identificacion_emp.Location = new System.Drawing.Point(160, 77);
            this.txt_identificacion_emp.Name = "txt_identificacion_emp";
            this.txt_identificacion_emp.Size = new System.Drawing.Size(163, 20);
            this.txt_identificacion_emp.TabIndex = 19;
            this.txt_identificacion_emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_identificacion_emp_KeyPress);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblid.ForeColor = System.Drawing.SystemColors.Control;
            this.lblid.Location = new System.Drawing.Point(12, 72);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(142, 25);
            this.lblid.TabIndex = 18;
            this.lblid.Text = "N° Identificacion";
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
            this.Eliminar,
            this.Editar});
            this.tablaEmpleado.Location = new System.Drawing.Point(47, 229);
            this.tablaEmpleado.Name = "tablaEmpleado";
            this.tablaEmpleado.ReadOnly = true;
            this.tablaEmpleado.RowHeadersWidth = 15;
            this.tablaEmpleado.RowTemplate.Height = 25;
            this.tablaEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEmpleado.Size = new System.Drawing.Size(831, 276);
            this.tablaEmpleado.TabIndex = 1;
            this.tablaEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmpleados_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 30;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(730, 110);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 37);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(730, 156);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 37);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(194, 202);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(82, 20);
            this.cont.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Cantidad Empleados";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tablaEmpleado);
            this.Controls.Add(this.Boton_crear_empleado);
            this.Controls.Add(this.list_cargo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_municipio_emp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_telefono_emp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_direccion_emp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre_emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_identificacion_emp);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "empleados";
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Boton_crear_empleado;
        private System.Windows.Forms.ComboBox list_cargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_municipio_emp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefono_emp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_direccion_emp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_identificacion_emp;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView tablaEmpleado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.TextBox cont;
        private System.Windows.Forms.Label label6;
    }
}