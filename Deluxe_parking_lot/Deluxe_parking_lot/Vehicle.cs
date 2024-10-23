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
        public Car(double size, string regNumber, string colour) : base(size, regNumber, colour) 
        {
            size = 1;
        }
    }

    public class Buss : Vehicle
    {
        public Buss(double size, string regNumber, string colour) : base(size, regNumber, colour)
        {
            size = 2;
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(double size, string regNumber, string colour) : base(size, regNumber, colour)
        {
            size = 0.5;
        }
    }
}
