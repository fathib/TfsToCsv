using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TfsToCsv
{
    public class WorkItem
    {

        [XmlAttribute]
        public int Id { get; set; }

        [XmlElement]
        public List<Field> Fields { get; set; }
    }
}
