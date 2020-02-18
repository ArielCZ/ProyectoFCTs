using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDatos
{
    public class Gestion
    {
        Datos datos;

        public Gestion(out string msg)
        {
            msg = "";
            datos = new Datos(out string error);
            if (!error.Equals(""))
            {
                msg = error;
            }
        }

        public List<Ciclos> GetCiclos()
        {
            return datos.Ciclos();
        }

        public int CantAlumnosCiclo(string idCiclo)
        {
            return datos.CantAlumnosCiclo(idCiclo);
        }

        public int CantAlumnosAsignados(string idCiclo)
        {
            return datos.CantAlumnosAsignadosFCT(idCiclo);
        }

        public List<Alumnos> AlumnosCiclo(string idCiclo)
        {
            return datos.AlumnosCiclo(idCiclo);
        }

        public List<Empresas> EmpresasCiclo(string idCiclo)
        {
            return datos.EmpresasCiclo(idCiclo);
        }


    }
}
