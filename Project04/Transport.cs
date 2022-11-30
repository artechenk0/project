using System;

namespace Project04
{
    public class Transport
    {
        public Transport(string name, string destination, double lenthDestination, int countSeats, int price, int saldTicket, int countTicket, DateTime coming, DateTime departure)
        {
            Name = name;
            Destination = destination;
            LenthDestination = lenthDestination;
            CountSeats = countSeats;
            Price = price;
            SaldTicket = saldTicket;
            CountTicket = countTicket;
            Coming = coming;
            Departure = departure;
        }

        string Name { get; set; }
        string Destination { get; set; }
        double LenthDestination { get; set; }
        int CountSeats { get; set; }
        int Price { get; set; }
        int SaldTicket { get; set; }
        int CountTicket { get; set; }
        DateTime Coming { get; set; }
        DateTime Departure { get; set; }
    }
}
