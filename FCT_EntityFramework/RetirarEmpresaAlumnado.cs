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
    public partial class RetirarEmpresaAlumnado : Form
    {
        private Alumnos selectedAlumn;
        public RetirarEmpresaAlumnado()
        {
            InitializeComponent();
        }

        private void RetirarEmpresaAlumnado_Load(object sender, EventArgs e)
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
            
        }

        private void BtnRetirarEmpresa_Click(object sender, EventArgs e)
        {
            var cicloSelected = (Ciclos)cboCiclos.SelectedItem;
            var alumnoSelected = (Alumnos)cboAlumnosCiclo.SelectedItem;
            if (cicloSelected == null)
            {
                MessageBox.Show("Elige un ciclo válido");
            }
            else if(alumnoSelected == null)
            {
                MessageBox.Show("Elige un alumno válido");
            }
            else
            {
                string result = Program.gestion.RetirarEmpresa((Alumnos)cboAlumnosCiclo.SelectedItem);
                if (result.Contains("eliminar"))
                {
                    DialogResult resultDialog = MessageBox.Show(result, "Aviso", MessageBoxButtons.YesNo);
                    if (resultDialog == DialogResult.Yes)
                    {
                        MessageBox.Show(Program.gestion.EliminarEmpresa(alumnoSelected));
                    }
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            
        }

        private void CboAlumnosCiclo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // selectedAlumn = (Alumnos)cboAlumnosCiclo.SelectedItem;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
