using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomThread
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p=new Program();
            ThreadStart ts = new ThreadStart(p.DoTask); //--> its basically a delegate ->threadstart
            //-> note there's no need to have a delegate, directly thread can be created and dotask can be called
            Thread t = new Thread(ts); //-> Thread t = new Thread(p.doTask);
            Thread t1 = new Thread(ts);
            t.Name = "My Thread...";
            t.Start();
            

            for (int i = 0; i < 10; i++)
            {
                if(i==5)
                {
                    t.Join(); //-> PLS HOVER OVER IT, WILL BLOCK CALLLING (MAIN THREAD) TILL THE TIME CUSTOM THREAD IS NOT EXECUTED
                }    
                Thread.Sleep(1000);
                Console.WriteLine($"Main Thread -- {i}");
            }

            //t.Resume(); //-> afte the above loop has finished executing this line will execute

            //-> scheduler decides which thread to execute first, not in our control


            Console.ReadKey();
        }

        public void DoTask()
        {
            Thread t = Thread.CurrentThread; //-> means dotask is executing on whatever thread the instance will come
            Console.WriteLine($"Custom Thread Name {t.Name}");
            for(int i = 0; i < 10; i++)
            {
                if(i==6)
                {
                    //t.Suspend();
                }
                Thread.Sleep(1000);
                Console.WriteLine($"Custom Thread -- {i}");
            }

        }
    }
}
