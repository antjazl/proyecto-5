using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AccesoDatos 
{
    public partial class publicacion
    {
        [XmlIgnore]
        public virtual List<especimen> especimen { get; set; }
        [XmlIgnore]
        public virtual List<nombrecomun> nombrecomun { get; set; }
        [XmlIgnore]
        public virtual List<nombrecomunpublicacion> nombrecomunpublicacion { get; set; }
        [XmlIgnore]
        public virtual List<publicacionautor> publicacionautor { get; set; }
        [XmlIgnore]
        public virtual List<publicacioncatalogo> publicacioncatalogo { get; set; }
        [XmlIgnore]
        public virtual List<publicacionenlace> publicacionenlace { get; set; }
        [XmlIgnore]
        public virtual List<sinonimo> sinonimo { get; set; }
        [XmlIgnore]
        public virtual List<taxapublicacion> taxapublicacion { get; set; }
    }
}
