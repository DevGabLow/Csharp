using System;
using ExceptionPersonal.Entities;
namespace ExceptionPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-Out date must be after check-in date");
            }
            else
            {
                Resevation reservation = new Resevation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter the data to update the reservation: ");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Erro in reservation : Reservation date for update must be future dates ");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-Out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkIn,checkOut);
                    Console.WriteLine("Reservation: "+ reservation);
                }
            }
        }
    }
}
