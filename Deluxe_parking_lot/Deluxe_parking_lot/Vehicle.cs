using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    public abstract class Vehicle
    {
        public double Size { get; set; }

        public string RegNumber { get; set; }

        public string Colour { get; set; }

        public Vehicle(string regNumber, string colour) 
        {
            RegNumber = regNumber; 
            Colour = colour;
        }
    }


    public class Car : Vehicle
    {
        public bool Electric { get; set; }
        public Car(string regNumber, string colour, bool electric) : base(regNumber, colour)
        {
            Size = 1;
            Electric = electric;
        }
    }

    public class Buss : Vehicle
    {
        public int AmountOfPassengers { get; set; }
        public Buss(string regNumber, string colour, int amountOfPassengers) : base(regNumber, colour)
        {
            Size = 2;
            AmountOfPassengers = amountOfPassengers;
        }
    }

    public class Motorcycle : Vehicle
    {
        public string KindOfMC { get; set; }
        public Motorcycle(string regNumber, string colour, string kindOfMC) : base(regNumber, colour)
        {
            Size = 0.5;
            KindOfMC = kindOfMC;
        }
    }
}
