using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDemo
{
    public class Calculator
    {
        public int No1 { get; set; }
        public int No2 { get; set; }
        public void Addition()
        {
            var result=No1+ No2;
            Console.WriteLine("Addition is: "+result);
        }
        public void Subtraction()
        {
            var result = No1 - No2;
            Console.WriteLine("Subtraction is: " + result);
        }

        public void Division()
        {
            var result = No1/No2;
            Console.WriteLine("Division is: " + result);
        }

        public void Multiplacation()
        {
            var result = No1 * No2;
            Console.WriteLine("Multiplication is: " + result);
        }

    }
}
