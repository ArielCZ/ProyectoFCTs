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
    public partial class Form1 : Form
    {
        private List<Alumnos> Alumnos;
        private List<Ciclos> Ciclos;
        private List<Empresas> EmpresasCiclo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ciclos = Program.gestion.GetCiclos();
            cboCiclos.Items.AddRange(Ciclos.ToArray());
            cboCiclos.DisplayMember = "Nombre";
            
        }

        private void CboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreCiclo.Text = cboCiclos.Text;
            Ciclos selectedCiclo = (Ciclos)cboCiclos.SelectedItem;
            txtAlumnosCiclo.Text = Program.gestion.CantAlumnosCiclo(selectedCiclo.Id).ToString();
            txtAlumnosAsignados.Text = Program.gestion.CantAlumnosAsignados(selectedCiclo.Id).ToString();

            Alumnos = Program.gestion.AlumnosCiclo(selectedCiclo.Id);
            EmpresasCiclo = Program.gestion.EmpresasCiclo(selectedCiclo.Id);


            dgvAlumnos.DataSource = Alumnos.Select(a => new { a.Nombre, a.Telefono, a.Aprobado }).ToList();
            dgvAlumnosAsignados.DataSource = Alumnos.Where(a => a.FCTs != null).ToList();
            dgvEmpresasCiclo.DataSource = EmpresasCiclo.ToList();
        }

    }
}
