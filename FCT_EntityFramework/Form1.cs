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
        }

    }
}
