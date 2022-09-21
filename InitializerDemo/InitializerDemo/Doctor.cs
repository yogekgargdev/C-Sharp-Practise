using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializerDemo
{
    public class Doctor
    {
        public int DID { get; set; }
        public string DName { get; }
        //-> Auto implemented read only props

        public string DName1 { get; private set; } //-> use this to initialise values leaving the constructor

        public Doctor()
        {
            DName = "Ram";
            //-> apart from here no where DName cannot be initialised
        }

        public override string ToString()
        {
            //-> DName="Yogek";// -> will show error
            DName1 = "Yogek";
            return "Dname: "+ DName+ " Dname1: "+DName1;

        }



    }
}
