using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoapSerialization
{
    [Serializable]
    
    public class Student
    {
        [XmlAttribute(AttributeName ="RollNumber")]
        public int Roll { get; set; }

        [XmlElement(ElementName = "Student Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Student Gender")]
        public string Gender { get; set; }

        [XmlElement(ElementName = "Student Mobile")]
        public string Mobile { get; set; }

        public override string ToString()
        {

            string s = "";
            s += $"\nRoll No.\t\t{Roll}";
            s += $"\nName.\t\t{Name}";
            s += $"\nGender.\t\t{Gender}";
            s += $"\nMobile.\t\t{Mobile}";

            return s;
        }
    }
}
