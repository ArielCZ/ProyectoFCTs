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
        public List<Alumnos> Alumnos;
        public List<Ciclos> Ciclos;
        public List<Empresas> EmpresasCiclo;
        public List<Profes> Profes;

        public Gestion(out string msg)
        {
            msg = "";
            datos = new Datos(out string error);
            if (!error.Equals(""))
            {
                msg = error;
            }
            GetCiclos();
        }

        public void GetCiclos()
        {
            Ciclos = datos.Ciclos();
        }

        public int CantAlumnosCiclo(string idCiclo)
        {
            return datos.CantAlumnosCiclo(idCiclo);
        }

        public int CantAlumnosAsignados(string idCiclo)
        {
            return datos.CantAlumnosAsignadosFCT(idCiclo);
        }

        public void AlumnosCiclo(string idCiclo)
        {
            Alumnos =  datos.AlumnosCiclo(idCiclo);
        }

        public void EmpresasdeCiclo(string idCiclo)
        {
            EmpresasCiclo = datos.EmpresasCiclo(idCiclo);
        }

        public void TodosProfes()
        {
            Profes = datos.Profes();
        }

        public string AsignarEmpresa(Ciclos ciclo, Alumnos alum, Empresas empresa, Profes profe, string tutorEmpresa)
        {
           return  datos.AsignarEmpresa(ciclo, alum, empresa, profe, tutorEmpresa);
        }

        public string RetirarEmpresa(Alumnos alum)
        {
            return datos.retirarEmpresa(alum);
        }

        public string EliminarEmpresa(Alumnos alum)
        {
            return datos.eliminarEmpresa(alum);
        }
    }
}
