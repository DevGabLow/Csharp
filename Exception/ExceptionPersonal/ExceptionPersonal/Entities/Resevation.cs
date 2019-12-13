using System;
using ExceptionPersonal.Entities.Exceptions;
namespace ExceptionPersonal.Entities
{
    class Resevation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Resevation() { }

        public Resevation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException(" Check-Out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
          

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation date for update must be future dates ");
            }
           if (checkOut <= checkIn)
            {
                throw new DomainException(" Check-Out date must be after check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            

        }

        public override string ToString()
        {
            return "Room: " + RoomNumber
                   +", check-in: " + CheckIn.ToString("dd/MM/yyyy")
                   + ", Check-Out: " + CheckOut.ToString("dd/MM/yyyy")
                   + ", " + Duration() + " Nights";
        }
    }
}
