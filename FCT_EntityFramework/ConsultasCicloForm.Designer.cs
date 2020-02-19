namespace FCT_EntityFramework
{
    partial class ConsultasCicloForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCiclos = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreCiclo = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAlumnosCiclo = new System.Windows.Forms.TextBox();
            this.txtAlumnosAsignados = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvAlumnosAsignados = new System.Windows.Forms.DataGridView();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvEmpresasCiclo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCiclos
            // 
            this.cboCiclos.FormattingEnabled = true;
            this.cboCiclos.Location = new System.Drawing.Point(86, 70);
            this.cboCiclos.Name = "cboCiclos";
            this.cboCiclos.Size = new System.Drawing.Size(189, 21);
            this.cboCiclos.TabIndex = 0;
            this.cboCiclos.SelectedIndexChanged += new System.EventHandler(this.CboCiclos_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 70);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Ciclo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(295, 71);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(120, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Nombre de ciclo";
            // 
            // txtNombreCiclo
            // 
            this.txtNombreCiclo.Location = new System.Drawing.Point(422, 71);
            this.txtNombreCiclo.Name = "txtNombreCiclo";
            this.txtNombreCiclo.Size = new System.Drawing.Size(242, 20);
            this.txtNombreCiclo.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(684, 71);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(152, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Alumnos/as del ciclo";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(939, 71);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(164, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Alumnos/as asignados";
            // 
            // txtAlumnosCiclo
            // 
            this.txtAlumnosCiclo.Location = new System.Drawing.Point(853, 72);
            this.txtAlumnosCiclo.Name = "txtAlumnosCiclo";
            this.txtAlumnosCiclo.Size = new System.Drawing.Size(51, 20);
            this.txtAlumnosCiclo.TabIndex = 6;
            // 
            // txtAlumnosAsignados
            // 
            this.txtAlumnosAsignados.Location = new System.Drawing.Point(1120, 72);
            this.txtAlumnosAsignados.Name = "txtAlumnosAsignados";
            this.txtAlumnosAsignados.Size = new System.Drawing.Size(50, 20);
            this.txtAlumnosAsignados.TabIndex = 7;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(36, 151);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(152, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Alumnos/as del ciclo";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(40, 187);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(435, 246);
            this.dgvAlumnos.TabIndex = 9;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(36, 484);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(326, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Alumnos/as del ciclo con empresa ya asignada";
            // 
            // dgvAlumnosAsignados
            // 
            this.dgvAlumnosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosAsignados.Location = new System.Drawing.Point(40, 507);
            this.dgvAlumnosAsignados.Name = "dgvAlumnosAsignados";
            this.dgvAlumnosAsignados.Size = new System.Drawing.Size(435, 150);
            this.dgvAlumnosAsignados.TabIndex = 11;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(644, 151);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(358, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Empresas para el ciclo (ordenadas alfabéticamente)";
            // 
            // dgvEmpresasCiclo
            // 
            this.dgvEmpresasCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresasCiclo.Location = new System.Drawing.Point(648, 187);
            this.dgvEmpresasCiclo.Name = "dgvEmpresasCiclo";
            this.dgvEmpresasCiclo.Size = new System.Drawing.Size(543, 316);
            this.dgvEmpresasCiclo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 682);
            this.Controls.Add(this.dgvEmpresasCiclo);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.dgvAlumnosAsignados);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtAlumnosAsignados);
            this.Controls.Add(this.txtAlumnosCiclo);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNombreCiclo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cboCiclos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresasCiclo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCiclos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox txtNombreCiclo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtAlumnosCiclo;
        private System.Windows.Forms.TextBox txtAlumnosAsignados;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridView dgvAlumnosAsignados;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DataGridView dgvEmpresasCiclo;
    }
}

