using CapaDatos;
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
    public partial class ConsultasCicloForm : Form
    {
        public ConsultasCicloForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCiclos.Items.AddRange(Program.gestion.Ciclos.ToArray());
            cboCiclos.DisplayMember = "Id";
            
        }

        private void CboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreCiclo.Text = cboCiclos.Text;
            Ciclos selectedCiclo = (Ciclos)cboCiclos.SelectedItem;
            txtAlumnosCiclo.Text = Program.gestion.CantAlumnosCiclo(selectedCiclo.Id).ToString();
            txtAlumnosAsignados.Text = Program.gestion.CantAlumnosAsignados(selectedCiclo.Id).ToString();

            Program.gestion.AlumnosCiclo(selectedCiclo.Id);
            Program.gestion.EmpresasdeCiclo(selectedCiclo.Id);


            dgvAlumnos.DataSource = Program.gestion.Alumnos.Select(a => new { a.Nombre, a.Telefono, a.Aprobado }).ToList();
            dgvAlumnosAsignados.DataSource = Program.gestion.Alumnos.Where(a => a.FCTs != null).ToList();
            dgvEmpresasCiclo.DataSource = Program.gestion.EmpresasCiclo.Select(empresa => new { empresa.Nombre, empresa.TelefonoContacto,
                Solicitudes = empresa.OfertasFCT.Where(c => c.IdCiclo == selectedCiclo.Id && c.IdEmpresa == empresa.Id).Select(c=>c.Cantidad).SingleOrDefault(),
            Asignados = empresa.FCTs.Count()}).ToList();
            
        }

    }
}
