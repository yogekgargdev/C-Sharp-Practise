using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    public class Student
    {
        private int roll{ get; set; }
        //private List<string> name;
        private Dictionary<string, string> name;
        private string mobile;

        public Student()
        {
            roll = 0;
            name = new Dictionary<string,string>(){ { "fname",""},{"mname","" },{"lname","" } }; 
            mobile = "";
        }

        //-> copy constructor
        public Student(Student s)
        {
            roll = s.SRoll;
            name = new Dictionary<string, string>() { { "fname", s["fname"] }, { "mname", s["mname"] }, { "lname", s["lname"] } };
            mobile = s.SMobile;

        }

        
        public int SRoll
        {
            get { return roll; }
            set { roll = value; }
        }

        public string SMobile
        {
            get { return mobile;  }
            set { mobile = value; }

        }

        //public string this[int i]
        //{
        //    get
        //    {
        //        return name[i];
        //    }
        //    set
        //    {
        //        name[i] = value;
        //    }
        //}

        public string this[string key]
        {
            get
            {
                return name[key];
            }
            set
            {
                name[key] = value;
            }
        }
        public override string ToString()
        {
            string s = "";
            s += $"\nRoll\t:\t{roll}";
            //s += $"\nFull Name\t:\t{name[0]} {name[1]} {name[2]}";
            s += $"\nFull Name\t:\t{name["fname"]} {name["mname"]} {name["lname"]}";
            s += $"\nMobile\t:\t{mobile}";

            return s;

        }

        public override bool Equals(object obj)
        {
            if(obj==null)
            {
                return false;
            }
            if(!(obj is Student))
            {
                return false;
            }
            else
            {
                Student s= obj as Student;
                if(s==null)
                {
                    return false;
                }
                else
                {
                    if (SRoll != s.SRoll)
                    {
                        return false;
                    }
                    else if (!(SMobile != s.SMobile))
                    {
                        return false;
                    }
                    else if ((name["fname"].Equals(s["fname"])) && (name["mname"].Equals(s["mname"])) && (name["lname"].Equals(s["lname"])))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

    }
}
