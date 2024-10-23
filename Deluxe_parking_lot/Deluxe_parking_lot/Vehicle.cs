using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    public abstract class Vehicle
    {
        public double Size {  get; set; }

        public string RegNumber { get; set; }

        public string Colour { get; set; }

        public Vehicle(double size, string regNumber, string colour) 
        {
            Size = size;
            RegNumber = regNumber; 
            Colour = colour;
        }
    }

    public class Car : Vehicle
    {
        public bool Electric { get; set; }
        public Car(double size, string regNumber, string colour, bool electric) : base(size, regNumber, colour) 
        {
            size = 1;
            Electric = electric;
        }
    }

    public class Buss : Vehicle
    {
        public int AmountOfPassengers { get; set; }
        public Buss(double size, string regNumber, string colour, int amountOfPassengers) : base(size, regNumber, colour)
        {
            size = 2;
            AmountOfPassengers = amountOfPassengers;
        }
    }

    public class Motorcycle : Vehicle
    {
        public string KindOfMC { get; set; }
        public Motorcycle(double size, string regNumber, string colour, string kindOfMC) : base(size, regNumber, colour)
        {
            size = 0.5;
            KindOfMC = kindOfMC;
        }
    }
}
