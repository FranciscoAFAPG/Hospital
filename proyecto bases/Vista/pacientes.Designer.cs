
namespace proyecto_bases
{
    partial class pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pacientes));
            this.label2 = new System.Windows.Forms.Label();
            this.list_medico = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_identificacion_pac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_municipio_pac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefono_pac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion_pac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_pac = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.Boton_crear_paciente = new System.Windows.Forms.Button();
            this.tablaPaciente = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.list_enfermedad = new System.Windows.Forms.ComboBox();
            this.txt_diagnostico_pac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(351, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Información Pacientes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // list_medico
            // 
            this.list_medico.FormattingEnabled = true;
            this.list_medico.Location = new System.Drawing.Point(447, 94);
            this.list_medico.Name = "list_medico";
            this.list_medico.Size = new System.Drawing.Size(163, 21);
            this.list_medico.TabIndex = 52;
            this.list_medico.SelectedIndexChanged += new System.EventHandler(this.list_medico_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(370, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Médico";
            // 
            // txt_identificacion_pac
            // 
            this.txt_identificacion_pac.Location = new System.Drawing.Point(132, 64);
            this.txt_identificacion_pac.Name = "txt_identificacion_pac";
            this.txt_identificacion_pac.Size = new System.Drawing.Size(163, 20);
            this.txt_identificacion_pac.TabIndex = 42;
            this.txt_identificacion_pac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_identificacion_pac_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Identificación";
            // 
            // txt_municipio_pac
            // 
            this.txt_municipio_pac.Location = new System.Drawing.Point(447, 68);
            this.txt_municipio_pac.Name = "txt_municipio_pac";
            this.txt_municipio_pac.Size = new System.Drawing.Size(163, 20);
            this.txt_municipio_pac.TabIndex = 40;
            this.txt_municipio_pac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_municipio_pac_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(351, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Municipio";
            // 
            // txt_telefono_pac
            // 
            this.txt_telefono_pac.Location = new System.Drawing.Point(132, 142);
            this.txt_telefono_pac.Name = "txt_telefono_pac";
            this.txt_telefono_pac.Size = new System.Drawing.Size(163, 20);
            this.txt_telefono_pac.TabIndex = 38;
            this.txt_telefono_pac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_pac_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Teléfono";
            // 
            // txt_direccion_pac
            // 
            this.txt_direccion_pac.Location = new System.Drawing.Point(132, 116);
            this.txt_direccion_pac.Name = "txt_direccion_pac";
            this.txt_direccion_pac.Size = new System.Drawing.Size(163, 20);
            this.txt_direccion_pac.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Dirección";
            // 
            // txt_nombre_pac
            // 
            this.txt_nombre_pac.Location = new System.Drawing.Point(132, 90);
            this.txt_nombre_pac.Name = "txt_nombre_pac";
            this.txt_nombre_pac.Size = new System.Drawing.Size(163, 20);
            this.txt_nombre_pac.TabIndex = 34;
            this.txt_nombre_pac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_pac_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(48, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(334, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Enfermedad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(662, 176);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 37);
            this.btnEliminar.TabIndex = 50;
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
            this.btnEditar.Location = new System.Drawing.Point(662, 123);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 37);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Boton_crear_paciente
            // 
            this.Boton_crear_paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Boton_crear_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_crear_paciente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_crear_paciente.Image = ((System.Drawing.Image)(resources.GetObject("Boton_crear_paciente.Image")));
            this.Boton_crear_paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Boton_crear_paciente.Location = new System.Drawing.Point(662, 69);
            this.Boton_crear_paciente.Name = "Boton_crear_paciente";
            this.Boton_crear_paciente.Size = new System.Drawing.Size(129, 37);
            this.Boton_crear_paciente.TabIndex = 48;
            this.Boton_crear_paciente.Text = "Agregar";
            this.Boton_crear_paciente.UseVisualStyleBackColor = false;
            this.Boton_crear_paciente.Click += new System.EventHandler(this.Boton_crear_paciente_Click);
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
            this.Eliminar,
            this.Editar});
            this.tablaPaciente.Location = new System.Drawing.Point(67, 258);
            this.tablaPaciente.Name = "tablaPaciente";
            this.tablaPaciente.ReadOnly = true;
            this.tablaPaciente.RowHeadersWidth = 15;
            this.tablaPaciente.RowTemplate.Height = 25;
            this.tablaPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPaciente.Size = new System.Drawing.Size(829, 242);
            this.tablaPaciente.TabIndex = 1;
            this.tablaPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPaciente_CellContentClick);
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
            // list_enfermedad
            // 
            this.list_enfermedad.FormattingEnabled = true;
            this.list_enfermedad.Location = new System.Drawing.Point(447, 121);
            this.list_enfermedad.Name = "list_enfermedad";
            this.list_enfermedad.Size = new System.Drawing.Size(163, 21);
            this.list_enfermedad.TabIndex = 53;
            this.list_enfermedad.SelectedIndexChanged += new System.EventHandler(this.list_enfermedad_SelectedIndexChanged);
            // 
            // txt_diagnostico_pac
            // 
            this.txt_diagnostico_pac.Location = new System.Drawing.Point(339, 154);
            this.txt_diagnostico_pac.Multiline = true;
            this.txt_diagnostico_pac.Name = "txt_diagnostico_pac";
            this.txt_diagnostico_pac.Size = new System.Drawing.Size(271, 59);
            this.txt_diagnostico_pac.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(225, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Diagnostico";
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
            this.btnClose.TabIndex = 56;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(978, 670);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_diagnostico_pac);
            this.Controls.Add(this.list_enfermedad);
            this.Controls.Add(this.tablaPaciente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.Boton_crear_paciente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_medico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_identificacion_pac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_municipio_pac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_telefono_pac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_direccion_pac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre_pac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pacientes";
            this.Text = "pacientes";
            this.Load += new System.EventHandler(this.pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox list_medico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_identificacion_pac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_municipio_pac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefono_pac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion_pac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_pac;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button Boton_crear_paciente;
        private System.Windows.Forms.DataGridView tablaPaciente;
        
        
        private System.Windows.Forms.ComboBox list_enfermedad;
        private System.Windows.Forms.TextBox txt_diagnostico_pac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}