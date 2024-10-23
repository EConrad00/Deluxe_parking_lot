using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    internal class Helper
    {
        Random rnd = new Random();
        public ParkingLot CreateLot()
        {
            List<Vehicle> vehicles = [];
            ParkingLot parkingLot = new (vehicles);
            return parkingLot;
        }

        private string CreateRegNumber()
        {
            string regNr = "";
            int randValue;
            for (int i = 0; i < 3; i++)
            {
                randValue = rnd.Next(0, 26);
                regNr += Convert.ToChar(randValue + 65);
            }
            for (int i = 0; i < 3; i++) 
            {
                randValue = rnd.Next(0, 10);
                regNr += randValue.ToString();
            }

            return regNr;
        }
        public ParkingLot CreateVehicle(ParkingLot parkingLot) 
        {
            int randvalue = rnd.Next(0, 3);

            if (randvalue == 0)
            {
                Car carA = new Car(CreateRegNumber(), "Red", false);
                parkingLot.Vehicles.Add(carA);
            }
            else if (randvalue == 1)
            {
                Buss bussA = new Buss(CreateRegNumber(), "Blue", 43);
                parkingLot.Vehicles.Add(bussA);
            }
            else if (randvalue == 2) 
            {
                Motorcycle motorcycleA = new Motorcycle(CreateRegNumber(), "Grey", "Harley");
                parkingLot.Vehicles.Add(motorcycleA);
            }

            return parkingLot;
        }

        public void DisplayCurrentLot(ParkingLot parkingLot)
        {
            int i = 0;
            int motorcycleCount = 0;
            decimal currentAmountOfMC = 0;
            foreach (var vehicle in parkingLot.Vehicles)
            {
                i++;
                if (vehicle is Car)
                {
                    Console.WriteLine($"Spot {i} {vehicle.RegNumber} {vehicle.Colour} {((Car)vehicle).Electric}");
                    motorcycleCount = 0;
                }
                else if (vehicle is Buss)
                {
                    Console.WriteLine($"Spot {i}-{i + 1} {vehicle.RegNumber} {vehicle.Colour} {((Buss)vehicle).AmountOfPassengers}");
                    i++;
                    motorcycleCount = 0;
                }
                else if(vehicle is Motorcycle)
                {
                    motorcycleCount++;
                    currentAmountOfMC++;
                    if (motorcycleCount == 2)
                    {
                        Console.WriteLine($"Spot {i - 1} {vehicle.RegNumber} {vehicle.Colour} {((Motorcycle)vehicle).KindOfMC}");
                        //i--;
                        motorcycleCount = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Spot {i} {vehicle.RegNumber} {vehicle.Colour} {((Motorcycle)vehicle).KindOfMC}");
                    }
                }
                else
                {
                    Console.WriteLine($"Spot {i} empty");
                    motorcycleCount = 0;
                }

            }
            for(; i < 15 + (Math.Round((currentAmountOfMC / 2),MidpointRounding.ToEven));)
            {
                i++;
                Console.WriteLine($"Spot {i - (Math.Round((currentAmountOfMC / 2), MidpointRounding.ToEven))} empty");
            }
        }
    }
}
