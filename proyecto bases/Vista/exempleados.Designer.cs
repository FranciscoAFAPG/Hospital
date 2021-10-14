
namespace proyecto_bases
{
    partial class exempleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exempleados));
            this.label2 = new System.Windows.Forms.Label();
            this.tablaExempleado = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_emp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.list_cargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(293, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Información Exempleados";
            // 
            // tablaExempleado
            // 
            this.tablaExempleado.AllowUserToAddRows = false;
            this.tablaExempleado.AllowUserToDeleteRows = false;
            this.tablaExempleado.AllowUserToResizeRows = false;
            this.tablaExempleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaExempleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaExempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaExempleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.tablaExempleado.Location = new System.Drawing.Point(47, 164);
            this.tablaExempleado.Name = "tablaExempleado";
            this.tablaExempleado.ReadOnly = true;
            this.tablaExempleado.RowHeadersWidth = 15;
            this.tablaExempleado.RowTemplate.Height = 25;
            this.tablaExempleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExempleado.Size = new System.Drawing.Size(831, 341);
            this.tablaExempleado.TabIndex = 1;
            this.tablaExempleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmpleados_CellContentClick);
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
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(168, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre_emp
            // 
            this.txt_nombre_emp.Location = new System.Drawing.Point(252, 118);
            this.txt_nombre_emp.Name = "txt_nombre_emp";
            this.txt_nombre_emp.Size = new System.Drawing.Size(182, 20);
            this.txt_nombre_emp.TabIndex = 21;
            this.txt_nombre_emp.TextChanged += new System.EventHandler(this.txt_nombre_emp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(491, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cargo";
            // 
            // list_cargo
            // 
            this.list_cargo.FormattingEnabled = true;
            this.list_cargo.Location = new System.Drawing.Point(567, 120);
            this.list_cargo.Name = "list_cargo";
            this.list_cargo.Size = new System.Drawing.Size(163, 21);
            this.list_cargo.TabIndex = 31;
            this.list_cargo.SelectedIndexChanged += new System.EventHandler(this.list_cargo_SelectedIndexChanged);
            // 
            // exempleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tablaExempleado);
            this.Controls.Add(this.list_cargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre_emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "exempleados";
            this.Text = "exempleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaExempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaExempleado;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_emp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox list_cargo;
    }
}