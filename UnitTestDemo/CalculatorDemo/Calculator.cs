using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("Default Constructor called");
        }
        public int Add(int a,int b)
        {
            return a+b;
        }
        public int Subtract(int a, int b)
        {
            return 0;
        }
        public int Multiply(int a, int b)
        {
            return 0;
        }
        public int Divide(int a, int b)
        {
            try
            {
                return a/b;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
