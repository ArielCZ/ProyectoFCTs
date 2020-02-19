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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnConsultaCiclo_Click(object sender, EventArgs e)
        {
            ConsultasCicloForm frmConsultasCiclo = new ConsultasCicloForm();
            frmConsultasCiclo.Show();
        }

        private void BtnAsignarEmpresa_Click(object sender, EventArgs e)
        {
            EmpresasForm frmEmpresa = new EmpresasForm();
            frmEmpresa.Show();
        }
    }
}
