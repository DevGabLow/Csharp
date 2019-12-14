using System;
using ExceptionPersonal.Entities;
using ExceptionPersonal.Entities.Exceptions;
namespace ExceptionPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            
           
                Resevation reservation = new Resevation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter the data to update the reservation: ");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                // string error = reservation.UpdateDates(checkIn, checkOut);
                /* Forma RUIM com problema de delegação
                 * DateTime now = DateTime.Now;
                 if (checkIn < now || checkOut < now)
                 {
                     Console.WriteLine("Erro in reservation : Reservation date for update must be future dates ");
                 }
                 else if (checkOut <= checkIn)
                 {
                     Console.WriteLine("Error in reservation: Check-Out date must be after check-in date");
                 }
                 if(error != null)
                 {
                     Console.WriteLine("Error in reservation: "+ error);
                 }
                 else
                 {

                 }
                 */
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }catch(FormatException e)
            {
                Console.WriteLine("Erro format: " + e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            }
        }
    }

