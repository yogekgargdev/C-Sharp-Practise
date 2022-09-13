using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    public class Player
    {
        private int pid;
        private string pname;

        public Player()
        {
            pid = 0;
            pname = "";
            Console.WriteLine("Default Memory Allocated");
        }

        public Player(int pid,string pname)
        {
            this.pid = pid;     
            this.pname = pname;
            Console.WriteLine("Parameterised Memory Allocated");
        }
        public int PID { get { return pid; } set { pid = value; } }
        public string PNAME { get { return pname; } set { pname = value; } }

        public override string ToString()
        {
            return $"ID\t\t{pid}\t\tPname\t\t{pname}";
        }

        ~Player()
        {
            Console.WriteLine("Memory Reclaimed from Managed code");
        }


    }
}
