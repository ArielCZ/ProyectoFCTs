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
            MessageBox.Show(Program.gestion.AsignarEmpresa((Ciclos) cboCiclos.SelectedItem, (Alumnos)cboAlumnosCiclo.SelectedItem, (Empresas)cboEmpresasCiclo.SelectedItem
                ,(Profes)cboTutor.SelectedItem, txtTutorEmpresa.Text));
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
