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
    
    public partial class MENU
    {
        public MENU()
        {
            this.PERMISOSPERFIL = new HashSet<PERMISOSPERFIL>();
        }
    
        public long IDMENU { get; set; }
        public string NOMBREMENU { get; set; }
        public Nullable<System.DateTime> FECHAMODIFICACION { get; set; }
        public string USUARIOMODIFICACION { get; set; }
    
        public virtual ICollection<PERMISOSPERFIL> PERMISOSPERFIL { get; set; }
    }
}
