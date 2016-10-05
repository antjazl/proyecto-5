using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos 
{
    public class TaxaPublicacion
    {
        public long IdTaxa { get; set; }
        public long IdPublicacion { get; set; }
        public bool Principal { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Titulo { get; set; }
        public string TituloSecundario { get; set; }
        public bool Editor { get; set; }
        public string Editorial { get; set; }
        public string Volumen { get; set; }
        public long IdPublicacionEnlace { get; set; }
        public string NombreArchivo { get; set; }
        public string EnlaceArchivo { get; set; }
        public bool Descarga { get; set; }
    }
}
