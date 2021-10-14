
namespace proyecto_bases
{
    partial class diagnosticoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diagnosticoPaciente));
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEnfermedad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tablaDiagnostico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(224, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listado Pacientes con enfermedad determinada";
            // 
            // cbxEnfermedad
            // 
            this.cbxEnfermedad.FormattingEnabled = true;
            this.cbxEnfermedad.Location = new System.Drawing.Point(427, 122);
            this.cbxEnfermedad.Name = "cbxEnfermedad";
            this.cbxEnfermedad.Size = new System.Drawing.Size(263, 21);
            this.cbxEnfermedad.TabIndex = 48;
            this.cbxEnfermedad.SelectedIndexChanged += new System.EventHandler(this.cbxEnfermedad_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(318, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Enfermedad";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // tablaDiagnostico
            // 
            this.tablaDiagnostico.AllowUserToAddRows = false;
            this.tablaDiagnostico.AllowUserToDeleteRows = false;
            this.tablaDiagnostico.AllowUserToResizeRows = false;
            this.tablaDiagnostico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tablaDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDiagnostico.Location = new System.Drawing.Point(41, 162);
            this.tablaDiagnostico.Name = "tablaDiagnostico";
            this.tablaDiagnostico.ReadOnly = true;
            this.tablaDiagnostico.RowHeadersWidth = 15;
            this.tablaDiagnostico.RowTemplate.Height = 25;
            this.tablaDiagnostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDiagnostico.Size = new System.Drawing.Size(852, 308);
            this.tablaDiagnostico.TabIndex = 56;
            // 
            // diagnosticoPaciente
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.tablaDiagnostico);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxEnfermedad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diagnosticoPaciente";
            this.Text = "diagnosticoPaciente";
            this.Load += new System.EventHandler(this.diagnosticoPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEnfermedad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView tablaDiagnostico;
    }
}