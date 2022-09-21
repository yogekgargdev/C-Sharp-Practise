using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexCustomerDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerDetails();
            Console.ReadKey();
        }
    }
}
