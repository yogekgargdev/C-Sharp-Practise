using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool status = false;
            while (status == false)
            {
               
                Console.WriteLine("Enter 1 for Train Reservation  and 2 for Bus Reseravation");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {

                    case 1:
                        //=>Train Reservation
                        TrainReservation trainReservation = new TrainReservation();
                        trainReservation.BookTicket();
                        trainReservation.DisplayBookingDetails();
                        status = true;
                        break;
                    case 2:
                        BusReservation busReservation = new BusReservation();
                        busReservation.BookTicket();
                        busReservation.DisplayBookingDetails();
                        status = true;
                        //-> Bus RESERVATION

                        break;
                    default:
                        status = false;
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
