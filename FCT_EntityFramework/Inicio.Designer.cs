﻿namespace FCT_EntityFramework
{
    partial class Inicio
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
            this.btnConsultaCiclo = new System.Windows.Forms.Button();
            this.btnAsignarEmpresa = new System.Windows.Forms.Button();
            this.btnRetirarEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaCiclo
            // 
            this.btnConsultaCiclo.Location = new System.Drawing.Point(346, 214);
            this.btnConsultaCiclo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultaCiclo.Name = "btnConsultaCiclo";
            this.btnConsultaCiclo.Size = new System.Drawing.Size(468, 43);
            this.btnConsultaCiclo.TabIndex = 0;
            this.btnConsultaCiclo.Text = "Consultas por ciclo";
            this.btnConsultaCiclo.UseVisualStyleBackColor = true;
            this.btnConsultaCiclo.Click += new System.EventHandler(this.BtnConsultaCiclo_Click);
            // 
            // btnAsignarEmpresa
            // 
            this.btnAsignarEmpresa.Location = new System.Drawing.Point(346, 306);
            this.btnAsignarEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsignarEmpresa.Name = "btnAsignarEmpresa";
            this.btnAsignarEmpresa.Size = new System.Drawing.Size(468, 43);
            this.btnAsignarEmpresa.TabIndex = 1;
            this.btnAsignarEmpresa.Text = "Asignar empresa a alumnado";
            this.btnAsignarEmpresa.UseVisualStyleBackColor = true;
            this.btnAsignarEmpresa.Click += new System.EventHandler(this.BtnAsignarEmpresa_Click);
            // 
            // btnRetirarEmpresa
            // 
            this.btnRetirarEmpresa.Location = new System.Drawing.Point(346, 405);
            this.btnRetirarEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetirarEmpresa.Name = "btnRetirarEmpresa";
            this.btnRetirarEmpresa.Size = new System.Drawing.Size(468, 43);
            this.btnRetirarEmpresa.TabIndex = 2;
            this.btnRetirarEmpresa.Text = "Retirar la empresa a un alumno/a";
            this.btnRetirarEmpresa.UseVisualStyleBackColor = true;
            this.btnRetirarEmpresa.Click += new System.EventHandler(this.BtnRetirarEmpresa_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnRetirarEmpresa);
            this.Controls.Add(this.btnAsignarEmpresa);
            this.Controls.Add(this.btnConsultaCiclo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaCiclo;
        private System.Windows.Forms.Button btnAsignarEmpresa;
        private System.Windows.Forms.Button btnRetirarEmpresa;
    }
}