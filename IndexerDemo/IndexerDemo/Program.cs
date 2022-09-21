using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Student s1;
            s.SRoll = 123;
            s.SMobile = "7888698233";

            //s[0] = "Ramesh";
            //s[1] = "Arun";
            //s[2] = "Gupta";

            s["fname"] = "Ramesh";
            s["mname"] = "Arun";
            s["lname"] = "Gupta";
            //Console.WriteLine($"Student Full Name is {s[0]} {s[1]} {s[2]}");
            Console.WriteLine($"Student Full Name is {s["fname"]} {s["mname"]} {s["lname"]}");
            s1 = s; //-> one student object to other object assignment (its memory reference), same object point being pointed
            // when we are using '='

            s.SRoll = 345;
            Console.WriteLine(s1);
            Console.WriteLine(s);

            if(s==s1)
            {
                Console.WriteLine("Both students are equal");
            }
            else
            {
                Console.WriteLine("Both students are NOT equal");
            }
            //NOTE == CHECKS FOR REF ONLYE

            //-> pls check below if else its not working properly
            if (s.Equals(s1))
            {
                Console.WriteLine("Both students are equal");
            }
            else
            {
                Console.WriteLine("Both students are NOT equal");
            }
           

            Student s2 = new Student(s);
            Console.WriteLine(s2);

            if(s1==s2)
            {
                Console.WriteLine("Both students are equal");
            }
            else
            {
                Console.WriteLine("Both students are NOT equal");
            }

            Console.Read();
        }
    }
}
