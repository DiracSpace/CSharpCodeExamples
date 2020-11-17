namespace registerPeople
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalif1 = new System.Windows.Forms.TextBox();
            this.txtCalif2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalif3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.colNombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalif1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalif2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalif3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPromedioGeneral = new System.Windows.Forms.Label();
            this.btnCalcularPromedioGeneral = new System.Windows.Forms.Button();
            this.txtPromedioGeneral = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(13, 32);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(148, 23);
            this.txtNombreAlumno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calif. 1";
            // 
            // txtCalif1
            // 
            this.txtCalif1.Location = new System.Drawing.Point(168, 32);
            this.txtCalif1.Name = "txtCalif1";
            this.txtCalif1.Size = new System.Drawing.Size(55, 23);
            this.txtCalif1.TabIndex = 4;
            // 
            // txtCalif2
            // 
            this.txtCalif2.Location = new System.Drawing.Point(231, 32);
            this.txtCalif2.Name = "txtCalif2";
            this.txtCalif2.Size = new System.Drawing.Size(55, 23);
            this.txtCalif2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calif. 2";
            // 
            // txtCalif3
            // 
            this.txtCalif3.Location = new System.Drawing.Point(295, 32);
            this.txtCalif3.Name = "txtCalif3";
            this.txtCalif3.Size = new System.Drawing.Size(55, 23);
            this.txtCalif3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calif. 3";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(356, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // colNombreAlumno
            // 
            this.colNombreAlumno.HeaderText = "Alumno";
            this.colNombreAlumno.Name = "colNombreAlumno";
            this.colNombreAlumno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNombreAlumno.Width = 180;
            // 
            // colCalif1
            // 
            this.colCalif1.HeaderText = "Calif. 1";
            this.colCalif1.Name = "colCalif1";
            this.colCalif1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCalif1.Width = 50;
            // 
            // colCalif2
            // 
            this.colCalif2.HeaderText = "Calif. 2";
            this.colCalif2.Name = "colCalif2";
            this.colCalif2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCalif2.Width = 50;
            // 
            // colCalif3
            // 
            this.colCalif3.HeaderText = "Calif. 3";
            this.colCalif3.Name = "colCalif3";
            this.colCalif3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCalif3.Width = 50;
            // 
            // colPromedio
            // 
            this.colPromedio.HeaderText = "Promedio";
            this.colPromedio.Name = "colPromedio";
            this.colPromedio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPromedio.Width = 60;
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreAlumno,
            this.colCalif1,
            this.colCalif2,
            this.colCalif3,
            this.colPromedio});
            this.dgvInfo.Location = new System.Drawing.Point(12, 89);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(435, 196);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.Text = "dataGridView1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Promedio General:";
            // 
            // lbPromedioGeneral
            // 
            this.lbPromedioGeneral.AutoSize = true;
            this.lbPromedioGeneral.Location = new System.Drawing.Point(489, 116);
            this.lbPromedioGeneral.Name = "lbPromedioGeneral";
            this.lbPromedioGeneral.Size = new System.Drawing.Size(0, 15);
            this.lbPromedioGeneral.TabIndex = 7;
            // 
            // btnCalcularPromedioGeneral
            // 
            this.btnCalcularPromedioGeneral.Location = new System.Drawing.Point(464, 137);
            this.btnCalcularPromedioGeneral.Name = "btnCalcularPromedioGeneral";
            this.btnCalcularPromedioGeneral.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularPromedioGeneral.TabIndex = 8;
            this.btnCalcularPromedioGeneral.Text = "Calcular";
            this.btnCalcularPromedioGeneral.UseVisualStyleBackColor = true;
            this.btnCalcularPromedioGeneral.Click += new System.EventHandler(this.btnCalcularPromedioGeneral_Click);
            // 
            // txtPromedioGeneral
            // 
            this.txtPromedioGeneral.Location = new System.Drawing.Point(454, 108);
            this.txtPromedioGeneral.Name = "txtPromedioGeneral";
            this.txtPromedioGeneral.ReadOnly = true;
            this.txtPromedioGeneral.Size = new System.Drawing.Size(100, 23);
            this.txtPromedioGeneral.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 297);
            this.Controls.Add(this.txtPromedioGeneral);
            this.Controls.Add(this.btnCalcularPromedioGeneral);
            this.Controls.Add(this.lbPromedioGeneral);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCalif3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCalif2);
            this.Controls.Add(this.txtCalif1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalif1;
        private System.Windows.Forms.TextBox txtCalif2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalif3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalif1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalif2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalif3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPromedioGeneral;
        private System.Windows.Forms.Button btnCalcularPromedioGeneral;
        private System.Windows.Forms.TextBox txtPromedioGeneral;
    }
}

