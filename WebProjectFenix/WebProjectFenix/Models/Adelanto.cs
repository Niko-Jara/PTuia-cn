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
    
    public partial class Adelanto
    {
        public int idAdelanto { get; set; }
        public int Cedula { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        public decimal PorcRebajo { get; set; }
        public decimal Monto { get; set; }
        public int idRubro { get; set; }
        public bool Estado { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
        public virtual Rubro Rubro { get; set; }
    }
}