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
            AsignarEmpresaAlumnado frmEmpresa = new AsignarEmpresaAlumnado();
            frmEmpresa.Show();
        }

        private void BtnRetirarEmpresa_Click(object sender, EventArgs e)
        {
            RetirarEmpresaAlumnado frmretirarEmpresaAlumnado = new RetirarEmpresaAlumnado();
            frmretirarEmpresaAlumnado.Show();
        }
    }
}
