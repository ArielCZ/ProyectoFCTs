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
    
    public partial class OfertasFCT
    {
        public int IdEmpresa { get; set; }
        public string IdCiclo { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Ciclos Ciclos { get; set; }
        public virtual Empresas Empresas { get; set; }
    }
}