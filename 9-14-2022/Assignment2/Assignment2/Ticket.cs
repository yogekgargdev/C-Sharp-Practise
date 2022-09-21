using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Ticket
    {
        private int id;
        private string PassengerName;
        private string source;

        private string destination;
        private int distance;
        private string mobile;
        private string email;

        public Ticket(int id, string passengerName, string source, string destination, int distance, string mobile, string email)
        {
            this.id = id;
            PassengerName = passengerName;
            this.source = source;
            this.destination = destination;
            this.distance = distance;
            this.mobile = mobile;
            this.email = email;
        }



        //-> function is overridable
        public virtual float CalculateCost()
        {
            return 50*distance;
        }

        public override string ToString()
        {
            string toret="ID\tPassengerName\tSource\tDestination\tDistance\tMobile\tEmail\tTotal Cost\t\n";
            toret = toret + $"{id}\t{PassengerName}\t{source}\t{destination}\t{distance}\t{mobile}\t{email}\t{CalculateCost()}";
            return toret;
        }

    }
}
