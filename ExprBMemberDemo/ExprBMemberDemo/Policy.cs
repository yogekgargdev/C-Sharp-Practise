using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExprBMemberDemo
{
    public class Policy
    {
        private int pid;
        private string pname;
        /*
        public Policy()
        {
            pname = "";
        }
        */

        public Policy() => pname = "";
        public Policy(string pname)=>this.pname = pname;   


        /*
        public string PolicyName
        {
            get { return pname; }
            set { pname = value; }
        }
        */

        public string PolicyName
        {
            get => pname;
            set => pname = value;
        }

        public override string ToString() => $"Policy Name is {pname}";
    


    }
}
