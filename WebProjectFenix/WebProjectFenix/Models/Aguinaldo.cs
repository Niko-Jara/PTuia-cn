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
    
    public partial class Aguinaldo
    {
        public int idAguinaldo { get; set; }
        public int Cedula { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public decimal Monto { get; set; }
        public bool Estado { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
    }
}