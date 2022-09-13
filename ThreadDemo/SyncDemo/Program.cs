using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDemo
{
     public class Program
    {
        static void Main(string[] args)
        {

            Calculator c1 = new Calculator() { No1=50,No2=5};
            Thread t1, t2, t3, t4;
            t1 = new Thread(c1.Addition);
            t2 = new Thread(c1.Subtraction);
            t3 = new Thread(c1.Multiplacation);
            t4 = new Thread(c1.Division);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            Console.Read();


        }
    }
}
