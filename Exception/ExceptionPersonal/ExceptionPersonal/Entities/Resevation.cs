using System;
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
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            CheckIn = checkin;
            CheckOut = checkout;
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
