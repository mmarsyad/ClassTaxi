using System;
using System.Collections.Generic;
using System.Text;

namespace TugasTaxi
{
    class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);

            if (OnDuty) Console.WriteLine("On Duty: Yes");
            else Console.WriteLine("On Duty: No");
            Console.WriteLine("Number Of Passenger: {0}\n", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("Jono sedang menjemput penumpang");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("Jono selesai mengantar penumpang");
        }


    }
}
