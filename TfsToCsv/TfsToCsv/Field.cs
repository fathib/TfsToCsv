using System.Xml.Serialization;

namespace TfsToCsv
{
    public class Field
    {
        [XmlAttribute]
        public string RefName { get; set; }

        [XmlAttribute]
        public string Value { get; set; }
    }
}