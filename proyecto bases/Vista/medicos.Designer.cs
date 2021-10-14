
namespace proyecto_bases
{
    partial class medicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicos));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txt_nombre_med = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_direccion_med = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefono_med = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_municipio_med = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lic_medica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.list_tipo_medico = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.Boton_crear_medico = new System.Windows.Forms.Button();
            this.tablaMedico = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.list_especialidad = new System.Windows.Forms.ComboBox();
            this.txt_identificacion_med = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(81, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txt_nombre_med
            // 
            this.txt_nombre_med.Location = new System.Drawing.Point(166, 118);
            this.txt_nombre_med.Name = "txt_nombre_med";
            this.txt_nombre_med.Size = new System.Drawing.Size(163, 20);
            this.txt_nombre_med.TabIndex = 1;
            this.txt_nombre_med.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_med_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(369, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Información Médicos";
            // 
            // txt_direccion_med
            // 
            this.txt_direccion_med.Location = new System.Drawing.Point(165, 150);
            this.txt_direccion_med.Name = "txt_direccion_med";
            this.txt_direccion_med.Size = new System.Drawing.Size(163, 20);
            this.txt_direccion_med.TabIndex = 5;
            this.txt_direccion_med.TextChanged += new System.EventHandler(this.txt_direccion_med_TextChanged);
            this.txt_direccion_med.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_med_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(74, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dirección";
            // 
            // txt_telefono_med
            // 
            this.txt_telefono_med.Location = new System.Drawing.Point(166, 183);
            this.txt_telefono_med.Name = "txt_telefono_med";
            this.txt_telefono_med.Size = new System.Drawing.Size(163, 20);
            this.txt_telefono_med.TabIndex = 7;
            this.txt_telefono_med.TextChanged += new System.EventHandler(this.txt_telefono_med_TextChanged);
            this.txt_telefono_med.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_med_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(81, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teléfono";
            // 
            // txt_municipio_med
            // 
            this.txt_municipio_med.Location = new System.Drawing.Point(468, 87);
            this.txt_municipio_med.Name = "txt_municipio_med";
            this.txt_municipio_med.Size = new System.Drawing.Size(163, 20);
            this.txt_municipio_med.TabIndex = 9;
            this.txt_municipio_med.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_municipio_med_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(371, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Municipio";
            // 
            // txt_lic_medica
            // 
            this.txt_lic_medica.Location = new System.Drawing.Point(468, 187);
            this.txt_lic_medica.Name = "txt_lic_medica";
            this.txt_lic_medica.Size = new System.Drawing.Size(163, 20);
            this.txt_lic_medica.TabIndex = 11;
            this.txt_lic_medica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lic_medica_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(335, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Licencia Médica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(355, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Especialidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(345, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo Médico";
            // 
            // list_tipo_medico
            // 
            this.list_tipo_medico.DisplayMember = "id_tipo_medico";
            this.list_tipo_medico.FormattingEnabled = true;
            this.list_tipo_medico.Location = new System.Drawing.Point(468, 118);
            this.list_tipo_medico.Name = "list_tipo_medico";
            this.list_tipo_medico.Size = new System.Drawing.Size(163, 21);
            this.list_tipo_medico.TabIndex = 16;
            this.list_tipo_medico.ValueMember = "id_tipo_medico";
            this.list_tipo_medico.SelectedIndexChanged += new System.EventHandler(this.list_tipo_medico_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(687, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 37);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(687, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 37);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.Boton_modificar_medico_Click);
            // 
            // Boton_crear_medico
            // 
            this.Boton_crear_medico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Boton_crear_medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_crear_medico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_crear_medico.Image = ((System.Drawing.Image)(resources.GetObject("Boton_crear_medico.Image")));
            this.Boton_crear_medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_crear_medico.Location = new System.Drawing.Point(687, 87);
            this.Boton_crear_medico.Name = "Boton_crear_medico";
            this.Boton_crear_medico.Size = new System.Drawing.Size(129, 37);
            this.Boton_crear_medico.TabIndex = 36;
            this.Boton_crear_medico.Text = "Agregar";
            this.Boton_crear_medico.UseVisualStyleBackColor = false;
            this.Boton_crear_medico.Click += new System.EventHandler(this.Boton_crear_medico_Click);
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
            this.Eliminar,
            this.Editar});
            this.tablaMedico.Location = new System.Drawing.Point(23, 230);
            this.tablaMedico.Name = "tablaMedico";
            this.tablaMedico.ReadOnly = true;
            this.tablaMedico.RowHeadersWidth = 15;
            this.tablaMedico.RowTemplate.Height = 25;
            this.tablaMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMedico.Size = new System.Drawing.Size(897, 277);
            this.tablaMedico.TabIndex = 1;
            this.tablaMedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMedico_CellContentClick);
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
            // list_especialidad
            // 
            this.list_especialidad.FormattingEnabled = true;
            this.list_especialidad.Location = new System.Drawing.Point(468, 155);
            this.list_especialidad.Name = "list_especialidad";
            this.list_especialidad.Size = new System.Drawing.Size(163, 21);
            this.list_especialidad.TabIndex = 40;
            this.list_especialidad.SelectedIndexChanged += new System.EventHandler(this.list_especialidad_SelectedIndexChanged);
            // 
            // txt_identificacion_med
            // 
            this.txt_identificacion_med.Location = new System.Drawing.Point(165, 84);
            this.txt_identificacion_med.Name = "txt_identificacion_med";
            this.txt_identificacion_med.Size = new System.Drawing.Size(163, 20);
            this.txt_identificacion_med.TabIndex = 42;
            this.txt_identificacion_med.TextChanged += new System.EventHandler(this.txt_identificacion_med_TextChanged);
            this.txt_identificacion_med.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_identificacion_med_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(42, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Identificación";
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
            // medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(978, 533);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txt_identificacion_med);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.list_especialidad);
            this.Controls.Add(this.tablaMedico);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.Boton_crear_medico);
            this.Controls.Add(this.list_tipo_medico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_lic_medica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_municipio_med);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_telefono_med);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_direccion_med);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre_med);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "medicos";
            this.Text = "medicos";
            this.Load += new System.EventHandler(this.medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txt_nombre_med;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_direccion_med;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_telefono_med;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_municipio_med;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lic_medica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox list_tipo_medico;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button Boton_crear_medico;
        private System.Windows.Forms.DataGridView tablaMedico;
        private System.Windows.Forms.ComboBox list_especialidad;
        private System.Windows.Forms.TextBox txt_identificacion_med;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}