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

        public int ParkingSpot { get; set; }

        public Vehicle(string regNumber, string colour, int parkingSpot) 
        {
            RegNumber = regNumber; 
            Colour = colour;
            ParkingSpot = parkingSpot;
        }
    }


    public class Car : Vehicle
    {
        public bool Electric { get; set; }
        public Car(string regNumber, string colour, int parkingSpot, bool electric) : base(regNumber, colour, parkingSpot)
        {
            Size = 1;
            Electric = electric;
            ParkingSpot = parkingSpot;
        }
    }

    public class Buss : Vehicle
    {
        public int AmountOfPassengers { get; set; }
        public Buss(string regNumber, string colour,int parkingSpot, int amountOfPassengers) : base(regNumber, colour, parkingSpot)
        {
            Size = 2;
            AmountOfPassengers = amountOfPassengers;
            ParkingSpot = parkingSpot;
        }
    }

    public class Motorcycle : Vehicle
    {
        public string KindOfMC { get; set; }
        public Motorcycle(string regNumber, string colour, int parkingSpot, string kindOfMC) : base(regNumber, colour, parkingSpot)
        {
            Size = 0.5;
            KindOfMC = kindOfMC;
            ParkingSpot = parkingSpot;
        }
    }
}
