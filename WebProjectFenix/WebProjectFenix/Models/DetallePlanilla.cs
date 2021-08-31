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
    
    public partial class DetallePlanilla
    {
        public int idDetallePlanilla { get; set; }
        public string CodPlanilla { get; set; }
        public int Cedula { get; set; }
        public int IdSalario { get; set; }
        public decimal SalarioNeto { get; set; }
        public int idRubro { get; set; }
        public decimal SalarioBruto { get; set; }
        public bool Estado { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
        public virtual Planilla Planilla { get; set; }
        public virtual Salario Salario { get; set; }
        public virtual Rubro Rubro { get; set; }
    }
}