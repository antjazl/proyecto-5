using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AccesoDatos 
{
    public partial class taxa
    {
        [XmlIgnore]
        public virtual List<especie> especie { get; set; }
        [XmlIgnore]
        public virtual List<especimen> especimen { get; set; }
        [XmlIgnore]
        public virtual List<multimedia> multimedia { get; set; }
        [XmlIgnore]
        public virtual List<nombrecomun> nombrecomun { get; set; }
        [XmlIgnore]
        public virtual List<ordenamientotaxa> ordenamientotaxa { get; set; }
        [XmlIgnore]
        public virtual List<sinonimo> sinonimo { get; set; }
        [XmlIgnore]
        public virtual List<taxa> taxa1 { get; set; }

        [XmlIgnore]
        public virtual taxa taxa2 { get; set; }
        [XmlIgnore]
        public virtual List<taxapublicacion> taxapublicacion { get; set; }
        [XmlIgnore]
        public virtual List<tipo> tipo { get; set; }
    }
}
