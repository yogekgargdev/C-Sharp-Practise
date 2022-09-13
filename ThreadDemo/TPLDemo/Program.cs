using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Task t = new Task(p.PerformTask);
            t.Start();
            Console.Read();
        }

        public void PerformTask()
        {
            for(int i=1;i<=5;i++)
            {
                Task.Delay(1000).Wait();
                //Thread.Sleep(1000); //-> above code can be used as an alteration to Thread.Sleep(1000)
                Console.WriteLine($"Task Value {i}");
            }
        }
    }
}
