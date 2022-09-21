using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 
{
    public class AcTicket:Ticket
    {
        private float AcCharges;

        public AcTicket(int id, string passengerName, string source, string destination, int distance, string mobile, string email) : base(id, passengerName, source, destination, distance, mobile, email)
        {
        }

        public override float CalculateCost()
        {
            return (base.CalculateCost()+ AcCharges);
        }

        public override string ToString()
        {
            string toret=base.ToString();
            toret = toret + "\n Ac Ticket Cost: " + AcCharges;
            return toret;
        }
    }
}
