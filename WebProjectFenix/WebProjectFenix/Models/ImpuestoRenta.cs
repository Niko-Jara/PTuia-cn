//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProjectFenix.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImpuestoRenta
    {
        public int idImpuestoRenta { get; set; }
        public int Cedula { get; set; }
        public decimal Monto { get; set; }
        public int idRangoImpuesto { get; set; }
        public int idRubro { get; set; }
        public bool Estado { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
        public virtual RangoImpuesto RangoImpuesto { get; set; }
        public virtual Rubro Rubro { get; set; }
    }
}
