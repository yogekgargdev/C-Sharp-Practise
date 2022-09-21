using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2
{
    public class BusReservation : Ireservation
    {
        Ticket t1; 
        public Ticket BookTicket()
        {
            Console.WriteLine("Bus Reservation");


            bool flag = false;
            string name = "";
            string source = "";
            string destination = "";
            string mobile = "";
            string email = "";
            int distance = 0;

            while (flag==false)
            {
                Console.WriteLine("Enter Passenger Name: ");
                name=Console.ReadLine();
                if (Regex.IsMatch(name, "^[a-zA-Z]"))
                {
                    break;

                }
            }

            while (flag == false)
            {
                Console.WriteLine("Enter Passenger Source: ");
                source = Console.ReadLine();
                if (Regex.IsMatch(source, "^[a-zA-Z]"))
                {
                    break;

                }
            }

            while (flag == false)
            {
                Console.WriteLine("Enter Passenger Destination: ");
                destination = Console.ReadLine();
                if (Regex.IsMatch(destination, "^[a-zA-Z]"))
                {
                    break;

                }
            }

            while (flag == false)
            {
                Console.WriteLine("Enter Passenger Distance: ");
                distance = int.Parse(Console.ReadLine());

                    break;

                
            }

            while (flag == false)
            {
                Console.WriteLine("Enter Passenger Mobile: ");
                mobile = Console.ReadLine();
                if (Regex.IsMatch(mobile, "^[0-9]{10}$"))
                {
                    break;

                }
            }

            while (flag == false)
            {
                Console.WriteLine("Enter Passenger Email: ");
                email = Console.ReadLine();
                if (Regex.IsMatch(email, "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
                {
                    break;

                }
            }
            t1 = new Ticket(1, name, source, destination, distance, mobile, email);
            return t1;




        }

        public void DisplayBookingDetails()
        {
            Console.WriteLine(t1.ToString()); 
        }
    }
}
