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
    
    public partial class especie
    {
        public especie()
        {
            this.amphibia = new HashSet<amphibia>();
            this.aves = new HashSet<aves>();
            this.enlacerelacionado = new HashSet<enlacerelacionado>();
            this.especiecatalogo = new HashSet<especiecatalogo>();
            this.mammalia = new HashSet<mammalia>();
            this.reptilia = new HashSet<reptilia>();
        }
    
        public long IdEspecie { get; set; }
        public long IdTaxa { get; set; }
        public string Etimologia { get; set; }
        public string Taxonomia { get; set; }
        public string HabitatBiologia { get; set; }
        public string Dieta { get; set; }
        public string Reproduccion { get; set; }
        public string InformacionAdicional { get; set; }
        public string ComentarioEstatusPoblacional { get; set; }
        public string Distribucion { get; set; }
        public string DistribucionGlobal { get; set; }
        public string ObservacionZonaAltitudinal { get; set; }
        public string RangoAltitudinal { get; set; }
        public string ReferenciaAreaProtegida { get; set; }
        public string Compilador { get; set; }
        public Nullable<System.DateTime> FechaCompilacion { get; set; }
        public string AutoriaCompilador { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> FechaEdicion { get; set; }
        public string AutoriaEditor { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public string Agradecimiento { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Categoria { get; set; }
    
        public virtual ICollection<amphibia> amphibia { get; set; }
        public virtual ICollection<aves> aves { get; set; }
        public virtual ICollection<enlacerelacionado> enlacerelacionado { get; set; }
        public virtual taxa taxa { get; set; }
        public virtual ICollection<especiecatalogo> especiecatalogo { get; set; }
        public virtual ICollection<mammalia> mammalia { get; set; }
        public virtual ICollection<reptilia> reptilia { get; set; }
    }
}