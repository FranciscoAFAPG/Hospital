
namespace proyecto_bases
{
    partial class listadoPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listadoPacientes));
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaListado = new System.Windows.Forms.DataGridView();
            this.txt_medico_atiende = new System.Windows.Forms.TextBox();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtpaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(199, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pacientes a Cargo del Medico Seleccionado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(31, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Médico que atiende:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(489, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Especialidad:";
            // 
            // tablaListado
            // 
            this.tablaListado.AllowUserToAddRows = false;
            this.tablaListado.AllowUserToDeleteRows = false;
            this.tablaListado.AllowUserToResizeRows = false;
            this.tablaListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaListado.Location = new System.Drawing.Point(36, 163);
            this.tablaListado.Name = "tablaListado";
            this.tablaListado.ReadOnly = true;
            this.tablaListado.RowHeadersWidth = 15;
            this.tablaListado.RowTemplate.Height = 25;
            this.tablaListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaListado.Size = new System.Drawing.Size(852, 308);
            this.tablaListado.TabIndex = 49;
            this.tablaListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaListado_CellContentClick);
            // 
            // txt_medico_atiende
            // 
            this.txt_medico_atiende.Location = new System.Drawing.Point(206, 102);
            this.txt_medico_atiende.Name = "txt_medico_atiende";
            this.txt_medico_atiende.Size = new System.Drawing.Size(217, 20);
            this.txt_medico_atiende.TabIndex = 50;
            this.txt_medico_atiende.TextChanged += new System.EventHandler(this.txt_medico_atiende_TextChanged);
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Location = new System.Drawing.Point(604, 104);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(219, 21);
            this.cbxEspecialidad.TabIndex = 51;
            this.cbxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbxEspecialidad_SelectedIndexChanged);
            // 
            // txtpaciente
            // 
            this.txtpaciente.Location = new System.Drawing.Point(206, 128);
            this.txtpaciente.Name = "txtpaciente";
            this.txtpaciente.Size = new System.Drawing.Size(217, 20);
            this.txtpaciente.TabIndex = 53;
            this.txtpaciente.TextChanged += new System.EventHandler(this.txtpaciente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(48, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Paciente atendido:";
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
            this.btnClose.TabIndex = 54;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listadoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtpaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxEspecialidad);
            this.Controls.Add(this.txt_medico_atiende);
            this.Controls.Add(this.tablaListado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listadoPacientes";
            this.Text = "listadoPacientes";
            this.Load += new System.EventHandler(this.listadoPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaListado;
        private System.Windows.Forms.TextBox txt_medico_atiende;
        private System.Windows.Forms.ComboBox cbxEspecialidad;
        private System.Windows.Forms.TextBox txtpaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
    }
}