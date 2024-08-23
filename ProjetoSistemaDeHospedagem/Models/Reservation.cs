using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSistemaDeHospedagem.Models
{
    public class Reservation
    {
        public Reservation(int bookedDays)
        {
            BookedDays = bookedDays;
        }

        public Reservation(List<Person> guests, Suite suite, int bookedDays)
        {
            Guests = guests;
            Suite = suite;
            BookedDays = bookedDays;
        }

        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int BookedDays { get; set; }

        public void RegisterGuests(List<Person> guests)
        {
            if (Suite == null)
            {
                throw new InvalidOperationException("Cannot register guests without registering a suite first.");
            }

            if (guests.Count > Suite.Capacity)
            { 
                throw new ArgumentException("The number of guests exceeds the capacity of the suite.");
            }

            Guests = guests;
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestCount()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyRate()
        {
            decimal total = BookedDays * Suite.RoomRate;
            if (BookedDays >= 10) {
                total -= total * .1M; 
            }

            return total;
        }

    }
}