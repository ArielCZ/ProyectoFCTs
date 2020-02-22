using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCT_EntityFramework
{
    public partial class AsignarEmpresaAlumnado : Form
    {
        
        public AsignarEmpresaAlumnado()
        {
            InitializeComponent();
        }

        private void EmpresasForm_Load(object sender, EventArgs e)
        {
            cboCiclos.Items.AddRange(Program.gestion.Ciclos.ToArray());
            cboCiclos.DisplayMember = "Id";

        }

        private void CboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAlumnosCiclo.Items.Clear();
            Ciclos selected = (Ciclos)cboCiclos.SelectedItem;

            Program.gestion.AlumnosCiclo(selected.Id);
            cboAlumnosCiclo.Items.AddRange(Program.gestion.Alumnos.ToArray());
            cboAlumnosCiclo.DisplayMember = "Nombre";
            Program.gestion.EmpresasdeCiclo(selected.Id);
            cboEmpresasCiclo.Items.AddRange(Program.gestion.EmpresasCiclo.ToArray());
            cboEmpresasCiclo.DisplayMember = "Nombre";
            Program.gestion.TodosProfes();
            cboTutor.Items.AddRange(Program.gestion.Profes.ToArray());
            cboTutor.DisplayMember = "Nombre";
        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            var cicloSelected = (Ciclos)cboCiclos.SelectedItem;
            var alumnoSelected = (Alumnos)cboAlumnosCiclo.SelectedItem;
            var empresaSelected = (Empresas)cboEmpresasCiclo.SelectedItem;
            var profeSelected = (Profes)cboTutor.SelectedItem;
            if (cicloSelected == null)
            {
                MessageBox.Show("Elige un ciclo válido.");
            }
            else if (alumnoSelected == null)
            {
                MessageBox.Show("Elige un alumno válido.");
            }
            else if (empresaSelected == null)
            {
                MessageBox.Show("Elige una empresa válida.");
            }
            else if (profeSelected == null)
            {
                MessageBox.Show("Elige un profesor válido");
            }
            else if (txtTutorEmpresa.Text == "") {
                MessageBox.Show("Elige un tutor de empresa válido");
            }
            else
            {
                MessageBox.Show(Program.gestion.AsignarEmpresa(cicloSelected, alumnoSelected, empresaSelected
                , profeSelected, txtTutorEmpresa.Text));
            }
            
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
