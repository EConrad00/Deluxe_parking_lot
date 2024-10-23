using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    internal class Helper
    {
        public ParkingLot CreateLot()
        {
            List<Vehicle> vehicles = [];
            ParkingLot parkingLot = new (vehicles);
            return parkingLot;
        }

        public ParkingLot CreateVehicle(ParkingLot parkingLot) 
        {
            Car carA = new Car("abc123","Red", false);
            Buss bussA = new Buss("xyz789", "Blue", 43);
            Motorcycle motorcycleA = new Motorcycle("shd235", "Grey", "Harley");
            
            parkingLot.Vehicles.Add(carA);
            parkingLot.Vehicles.Add(bussA);
            parkingLot.Vehicles.Add(motorcycleA);

            return parkingLot;
        }

        public void DisplayCurrentLot(ParkingLot parkingLot)
        {
            int i = 0;
            foreach (var vehicle in parkingLot.Vehicles)
            {
                i++;
                if (vehicle == ((Car)vehicle))
                {
                    Console.WriteLine($"Spot{i} {vehicle.RegNumber} {vehicle.Colour} {((Car)vehicle).Electric}");
                }
                else if (vehicle == ((Buss)vehicle))
                {
                    Console.WriteLine($"Spot{i} {vehicle.RegNumber} {vehicle.Colour} {((Buss)vehicle).AmountOfPassengers}");
                }
                else if(vehicle == ((Motorcycle)vehicle))
                {
                    Console.WriteLine($"Spot{i} {vehicle.RegNumber} {vehicle.Colour} {((Motorcycle)vehicle).KindOfMC}");
                }
                else
                {
                    Console.WriteLine($"Spot {i}");
                }

            }
        }
    }
}
