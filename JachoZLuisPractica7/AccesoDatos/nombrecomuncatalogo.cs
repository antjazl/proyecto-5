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
    
    public partial class nombrecomuncatalogo
    {
        public long IdNombreComunCatalogo { get; set; }
        public long IdNombreComun { get; set; }
        public long IdCatalogo { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Criterio { get; set; }
        public string PublicacionListaRoja { get; set; }
    
        public virtual catalogo catalogo { get; set; }
        public virtual nombrecomun nombrecomun { get; set; }
    }
}
