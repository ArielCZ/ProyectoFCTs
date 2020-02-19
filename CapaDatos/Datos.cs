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
        public Datos(out string msg)
        {
            msg = "";
            try
            {
                bdFCTsEntities = new BdFCTsEntities();
            }
            catch (Exception ex)
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
            return cicloBuscar.Alumnos.OrderByDescending(a => a.Aprobado).ThenBy(a => a.Nombre).ToList(); ;
        }

        public List<Empresas> EmpresasCiclo(string idCiclo)
        {
            Ciclos cicloBuscar = new Ciclos(idCiclo);
            cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
            if (cicloBuscar == null) return null;
            return cicloBuscar.OfertasFCT.Select(o => o.Empresas).OrderBy(e => e.Nombre).ToList();
        }


        public List<Profes> Profes()
        {
            return bdFCTsEntities.Profes.ToList();
        }


        public string AsignarEmpresa(Ciclos ciclo, Alumnos alum, Empresas emp, Profes profe, string tutorEmpresa)
        {
            Ciclos cicloBuscar = bdFCTsEntities.Ciclos.Find(ciclo.Id);
            if (cicloBuscar == null) return $"No existe el ciclo {ciclo.Nombre}";
            Profes tutor = bdFCTsEntities.Profes.Find(profe.Id);

            if (tutor == null) return $"No existe el tutor o tutora del instituto {profe.Nombre}";
            Alumnos alumno = bdFCTsEntities.Alumnos.Find(alum.NMatricula);

            if (alumno == null) return $"El alumno/a {alum.Nombre} no existe o no es del ciclo {cicloBuscar.Nombre}";
            Empresas empresa = bdFCTsEntities.Empresas.Find(emp.Id);

            if (empresa == null) return $"No existe la empresa {emp.Nombre}";
            OfertasFCT ofertas = bdFCTsEntities.OfertasFCT.Find(empresa.Id, cicloBuscar.Id);

            if (ofertas == null) return $"La empresa {empresa.Nombre} no ha solicitado alumnado para el ciclo {cicloBuscar.Nombre}";

            if (!alumno.Aprobado) return $"El alumno no ha aprobado el ciclo {cicloBuscar.Nombre}";
            if (empresa.FCTs.Count() == ofertas.Cantidad) return $"La empresa {empresa.Nombre} ya tiene el/los {ofertas.Cantidad} alumnos/as asignados";
            if (alumno.FCTs != null) return $"El alumno {alumno.Nombre} ya tiene asignada la empresa {alumno.FCTs.Empresas.Nombre}";
            FCTs nuevaFct = new FCTs(alum.NMatricula, emp.Id, profe.Nombre, tutorEmpresa, alum, emp, profe);
            FCTs fctEncontrada = bdFCTsEntities.FCTs.Find(nuevaFct.NMatricula);
            
            if (fctEncontrada != null) return "No se completar el proceso, Error con la base de datos";
            bdFCTsEntities.FCTs.Add(nuevaFct);
            bdFCTsEntities.SaveChanges();
            return "Se ha añadido correctamente";
        }


        public string retirarEmpresa(Alumnos alum)
        {
            Alumnos alumno = bdFCTsEntities.Alumnos.Find(alum.NMatricula);
            if (alumno == null) return $"El alumno/a {alum.Nombre} no existe";
            if (!alumno.Aprobado) return $"El alumno/a {alumno.Nombre} no puede tener asignada empresa porque no ha aprobado el curso";
            if (alumno.FCTs == null) return $"El alumno/a {alumno.Nombre} no tiene asignada empresa";
            return $"El alumno/a {alumno.Nombre} tiene asignada la empresa {alumno.FCTs.Empresas.Nombre}, ¿Deseas eliminar la asignación?";
        }

        public string eliminarEmpresa(Alumnos alum)
        {
            bdFCTsEntities.FCTs.Remove(alum.FCTs);
            bdFCTsEntities.SaveChanges();
            return "Eliminado correctamente";
        }

    }
}
