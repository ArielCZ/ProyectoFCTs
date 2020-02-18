﻿using Entidades;
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

        public int AlumnosDeCiclo(string idCiclo)
        {
            Ciclos cicloBuscar = new Ciclos(idCiclo);
            cicloBuscar = bdFCTsEntities.Ciclos.Find(idCiclo);
            if (cicloBuscar == null)
            {
                return 0;
            }
            return cicloBuscar.Alumnos.Count();
        }


    }
}
