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
    
    public partial class Usuario
    {
        public int idUsuario { get; set; }
        public int Cedula { get; set; }
        public string Usuario1 { get; set; }
        public string Contrasena { get; set; }
        public int idRol { get; set; }
        public bool Estado { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
        public virtual Rol Rol { get; set; }
    }
}