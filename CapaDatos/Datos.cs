using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    
    public class Datos
    {
        BdFCTsEntities bdFCTsEntities;
        public Datos( out string msg)
        {
            msg = "";
            try
            {
                bdFCTsEntities = new BdFCTsEntities();
            } catch(Exception ex)
            {
                msg = ex.Message;
            }
        }

        public List<Ciclos> Ciclos()
        {
            return bdFCTsEntities.Ciclos.ToList();
        }

        public int CantAlumnosCiclo(string idCiclo)
        {
            Ciclos cicloBuscar = new Ciclos(idCiclo);
            cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
            if (cicloBuscar == null)
            {
                return 0;
            }
            return cicloBuscar.Alumnos.Count();
        }

        public int CantAlumnosAsignadosFCT(string idCiclo)
        {
            Ciclos cicloBuscar = new Ciclos(idCiclo);
            cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
            if (cicloBuscar == null) return 0;
            List<Alumnos> alumnosCiclo = cicloBuscar.Alumnos.ToList();
            return alumnosCiclo.Where(a => a.FCTs != null).ToList().Count();
        }

        public List<Alumnos> AlumnosCiclo(string idCiclo)
        {
            Ciclos cicloBuscar = new Ciclos(idCiclo);
            cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
            if (cicloBuscar == null) return null;
            return cicloBuscar.Alumnos.OrderByDescending(a => a.Aprobado).ThenBy(a=>a.Nombre).ToList(); ;
        }

        public List<Empresas> EmpresasCiclo(string idCiclo)
        {
            Ciclos cicloBuscar = new Ciclos(idCiclo);
            cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
            if (cicloBuscar == null) return null;
            return cicloBuscar.OfertasFCT.Select(o => o.Empresas).ToList();
        }


    }
}
