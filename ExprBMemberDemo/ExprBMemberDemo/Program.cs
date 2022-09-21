using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExprBMemberDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Policy p = new Policy("Life Cover");
            p.PolicyName = "Family Cover";

            Console.WriteLine("Policy name is" + p.PolicyName);
            Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
