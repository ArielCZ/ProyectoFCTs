//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class FCTs
    {
        public int NMatricula { get; set; }
        public int IdEmpresa { get; set; }
        public string TutorInsti { get; set; }
        public string TutorEmpresa { get; set; }
    
        public virtual Alumnos Alumnos { get; set; }
        public virtual Empresas Empresas { get; set; }
        public virtual Profes Profes { get; set; }
    }
}