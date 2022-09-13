using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDemo
{
    public class Calculator
    {
        public int No1 { get; set; }
        public int No2 { get; set; }

        public int Result { get; set; }
        public void Addition()
        {
            Result=No1+ No2;
            Thread.Sleep(1000);
            Console.WriteLine("Addition is: "+ Result);
        }
        public void Subtraction()
        {
            Result = No1 - No2;
            Thread.Sleep(1000);
            Console.WriteLine("Subtraction is: " + Result);
        }

        public void Division()
        {
            Result = No1/No2;
            Thread.Sleep(1000);
            Console.WriteLine("Division is: " + Result);
        }

        public void Multiplacation()
        {
            Result = No1 * No2;
            Thread.Sleep(1000); //-> since the thread is halting in bw there is inconsistency, since all threads have a common variable
            Console.WriteLine("Multiplication is: " + Result);
        }

    }
}
