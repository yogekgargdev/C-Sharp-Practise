using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NullableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-> Nullable Types

            // int a=null; this will show compile time error
            //nullable types
            int? a = null;
            // int b = a;  this will show compile time error 'int?' and 'int'
            //int b=a.Value; this will throw exception if a=null, but will work if a has a value
            int b=0;
            if(a!=null)
            {
                b = a.Value;
            }
            Console.WriteLine(b);

            //-> if we decalre p as null we cannot access PID ANF Pname



            Player p = new Player { PID = 345, PName = "Mohantty" };
            Console.WriteLine("ID: "+p.PID);
            Console.WriteLine("Name: "+p.PName);

            Player p1 = null;
            Console.WriteLine("ID: " + p1?.PID);
            Console.WriteLine("Name: " + p1?.PName);





            Console.Read();
        }
    }
}
