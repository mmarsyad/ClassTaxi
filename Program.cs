using System;

namespace TugasTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Taxi
            Taxi taxi = new Taxi();

            // Pengesetan nilai Properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // Pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
