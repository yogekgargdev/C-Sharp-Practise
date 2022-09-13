using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
    public class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
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
