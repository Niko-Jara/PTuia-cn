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
    
    public partial class Planilla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Planilla()
        {
            this.DetallePlanillas = new HashSet<DetallePlanilla>();
        }
    
        public string CodPlanilla { get; set; }
        public int Cedula { get; set; }
        public int Anno { get; set; }
        public int Semana { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public System.DateTime FechaCierre { get; set; }
        public int idEstadoPlanilla { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePlanilla> DetallePlanillas { get; set; }
        public virtual EstadoPlanilla EstadoPlanilla { get; set; }
    }
}