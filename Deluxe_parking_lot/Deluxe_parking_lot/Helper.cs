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

        //public double CurrentSize { get; set; }
        //public ParkingLot CreateLot()
        //{
        //    List<Vehicle> vehicles = [];
        //    ParkingLot parkingLot = new (vehicles);
        //    return parkingLot;
        //}

        public static string CreateRegNumber()
        {
            string regNr = "";
            int randValue;
            for (int i = 0; i < 3; i++)
            {
                randValue = Random.Shared.Next(0, 26);
                regNr += Convert.ToChar(randValue + 65);
            }
            for (int i = 0; i < 3; i++) 
            {
                randValue = Random.Shared.Next(0, 10);
                regNr += randValue.ToString();
            }

            return regNr;
        }
        //public void CreateVehicle(ParkingLot parkingLot) 
        //{
        //    int randvalue = rnd.Next(0, 3);

        //    if (randvalue == 0)
        //    {
        //        Car carA = new Car(CreateRegNumber(), "Red", false);
        //        parkingLot.Vehicles.Add(carA);
        //        CurrentSize = (CurrentSize + carA.Size);
        //    }
        //    else if (randvalue == 1)
        //    {
        //        Buss bussA = new Buss(CreateRegNumber(), "Blue", 43);
        //        parkingLot.Vehicles.Add(bussA);
        //        CurrentSize = (CurrentSize + bussA.Size);
        //    }
        //    else if (randvalue == 2) 
        //    {
        //        Motorcycle motorcycleA = new Motorcycle(CreateRegNumber(), "Grey", "Harley");
        //        parkingLot.Vehicles.Add(motorcycleA);
        //        CurrentSize = (CurrentSize + motorcycleA.Size);
        //    }

        //}

        public void CheckOut(ParkingLot parkingLot)
        {
            parkingLot.CurrentSize = (parkingLot.CurrentSize - parkingLot.Vehicles[4].Size);
            parkingLot.Vehicles.RemoveAt(4);
            parkingLot.AvailableSpots[8] = 0;
        }

        public void DisplayCurrentLot(ParkingLot parkingLot)
        {
            int i = 0;
            //int motorcycleCount = 0;
            //decimal currentAmountOfMC = 0;
            foreach (var vehicle in parkingLot.Vehicles)
            {
                i++;
                if (vehicle is Car)
                {
                    Console.WriteLine($"Spot {vehicle.ParkingSpot} {vehicle.RegNumber} {vehicle.Colour} {((Car)vehicle).Electric}");
                    //i++;
                    //motorcycleCount = 0;
                }
                else if (vehicle is Buss)
                {
                    Console.WriteLine($"Spot {vehicle.ParkingSpot}-{vehicle.ParkingSpot + 1} {vehicle.RegNumber} {vehicle.Colour} {((Buss)vehicle).AmountOfPassengers}");
                    i++;
                    //motorcycleCount = 0;
                }
                else if(vehicle is Motorcycle)
                {
                    //motorcycleCount++;
                    //currentAmountOfMC++;
                    
                    Console.WriteLine($"Spot {vehicle.ParkingSpot} {vehicle.RegNumber} {vehicle.Colour} {((Motorcycle)vehicle).KindOfMC}");
                        //i++;
                }
                else
                {
                    //i++;
                    Console.WriteLine($"Spot {i} empty");
                    //i--;
                    //motorcycleCount = 0;
                }
                //i++;

            }
            //for(; i < 15 + (Math.Round((currentAmountOfMC / 2),MidpointRounding.ToEven));)
            //{
            //    i++;
            //    Console.WriteLine($"Spot {i - (Math.Round((currentAmountOfMC / 2), MidpointRounding.ToEven))} empty");
            //}
        }
    }
}
