//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class autor
    {
        public autor()
        {
            this.autorbiografia = new HashSet<autorbiografia>();
            this.publicacionautor = new HashSet<publicacionautor>();
        }
    
        public long IdAutor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string EnlaceBiografia { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual ICollection<autorbiografia> autorbiografia { get; set; }
        public virtual ICollection<publicacionautor> publicacionautor { get; set; }
    }
}
