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

            Action act= new Action(p.PerformTask);
            Task t = new Task(act); //-> above 2 lines works same as -- Task t = new Task(p.PerformTask);
            Task t2 = new Task(delegate ()
            {
                Console.WriteLine("Anonymous Functions");
            });

            Task t3 = new Task(delegate ()
            {
                Console.WriteLine("USing lambda operators");
            });
            Task<int> tg = new Task<int>(() =>
            {
                return 10;

            });
            tg.Start();
            tg.Wait(); // we will wait for tg to complete otherwise tg.isCompleted is false
            if(tg.IsCompleted)
            {
                Console.WriteLine($"Result : {tg.Result}");
            }
            t2.Start();
            t.Start();
            t3.Start();



            //Task t = new Task(p.PerformTask); //-> here parameter is an action delegate
            //t.Start();
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
