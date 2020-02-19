namespace FCT_EntityFramework
{
    partial class RetirarEmpresaAlumnado
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cboCiclos = new System.Windows.Forms.ComboBox();
            this.cboAlumnosCiclo = new System.Windows.Forms.ComboBox();
            this.btnRetirarEmpresa = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(263, 164);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Ciclo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(263, 295);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Alumnos/as del ciclo";
            // 
            // cboCiclos
            // 
            this.cboCiclos.FormattingEnabled = true;
            this.cboCiclos.Location = new System.Drawing.Point(498, 161);
            this.cboCiclos.Name = "cboCiclos";
            this.cboCiclos.Size = new System.Drawing.Size(111, 21);
            this.cboCiclos.TabIndex = 2;
            this.cboCiclos.SelectedIndexChanged += new System.EventHandler(this.CboCiclos_SelectedIndexChanged);
            // 
            // cboAlumnosCiclo
            // 
            this.cboAlumnosCiclo.FormattingEnabled = true;
            this.cboAlumnosCiclo.Location = new System.Drawing.Point(498, 295);
            this.cboAlumnosCiclo.Name = "cboAlumnosCiclo";
            this.cboAlumnosCiclo.Size = new System.Drawing.Size(297, 21);
            this.cboAlumnosCiclo.TabIndex = 3;
            this.cboAlumnosCiclo.SelectedIndexChanged += new System.EventHandler(this.CboAlumnosCiclo_SelectedIndexChanged);
            // 
            // btnRetirarEmpresa
            // 
            this.btnRetirarEmpresa.Location = new System.Drawing.Point(394, 483);
            this.btnRetirarEmpresa.Name = "btnRetirarEmpresa";
            this.btnRetirarEmpresa.Size = new System.Drawing.Size(192, 47);
            this.btnRetirarEmpresa.TabIndex = 4;
            this.btnRetirarEmpresa.Text = "&Retirar Empresa";
            this.btnRetirarEmpresa.UseVisualStyleBackColor = true;
            this.btnRetirarEmpresa.Click += new System.EventHandler(this.BtnRetirarEmpresa_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(646, 483);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(192, 47);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // RetirarEmpresaAlumnado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 674);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRetirarEmpresa);
            this.Controls.Add(this.cboAlumnosCiclo);
            this.Controls.Add(this.cboCiclos);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "RetirarEmpresaAlumnado";
            this.Text = "RetirarEmpresaAlumnado";
            this.Load += new System.EventHandler(this.RetirarEmpresaAlumnado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox cboCiclos;
        private System.Windows.Forms.ComboBox cboAlumnosCiclo;
        private System.Windows.Forms.Button btnRetirarEmpresa;
        private System.Windows.Forms.Button btnVolver;
    }
}