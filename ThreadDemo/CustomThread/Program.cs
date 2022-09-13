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
        public void DoTask()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
            for (int i = 1; i <= 10; i++)
            {

                //if (i == 6)
                //{
                //    t.Join();
                //    //t.Suspend();
                //}
                Thread.Sleep(1000);
                Console.WriteLine($"Custom thread --{i}");
            }
        }
        public void DoTask(object a)
        {
            int st = (int)a;
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
            for (int i = 1; i <= st; i++)
            {



                //if (i == 6)
                //{
                //    t.Suspend();
                //}
                Thread.Sleep(1000);
                Console.WriteLine($"Param Custom thread --{i}");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ThreadStart ts = new ThreadStart(p.DoTask);
            Thread t = new Thread(ts);//Thread t = new Thread(p.DoTask);
            Thread t1 = Thread.CurrentThread;
            t.Name = "Main Thread";
            t.Start();
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    t.Join();//use to block thread
                }
                Thread.Sleep(1000);
                Console.WriteLine($"Main thread --{i}");
            }
            //custom thread stop at i==6 and resume after completing main thread
            //t.Resume();



            ParameterizedThreadStart ps = new ParameterizedThreadStart(p.DoTask);
            Thread t2 = new Thread(ps);//Thread t = new Thread(p.DoTask);
            t2.Name = "Param Thread";
            t2.Start(15);
        }
    }
}