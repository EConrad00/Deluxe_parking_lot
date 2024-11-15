using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    internal class Helper
    {

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
       
        //public void CheckOut(ParkingLot parkingLot)
        //{
        //    parkingLot.CurrentSize = (parkingLot.CurrentSize - parkingLot.Vehicles[4].Size);
        //    parkingLot.Vehicles.RemoveAt(4);

        //    for (int i = 0; i < 30; i++)
        //    {
        //        if (parkingLot.AvailableSpots[i] == parkingLot.Vehicles[4].ParkingSpot)
        //        {
        //            parkingLot.AvailableSpots[i] = 0;
        //        }
        //    }
        //}

        public static void DisplayCurrentLotV2(ParkingLot parkingLot)
        {
            //int i = 0;
            bool wasBuss = false;
            foreach (var spots in parkingLot.AvailableSpotsV2.Keys)
            {
                parkingLot.AvailableSpotsV2.TryGetValue(spots, out List<Vehicle> vehicles);
                if (vehicles.Count > 0)
                {
                    if (vehicles[0] is Motorcycle)
                    {
                        if (vehicles.Count > 1)
                        {

                            Console.WriteLine($"Spot {vehicles[0].ParkingSpot} {vehicles[0].RegNumber} {vehicles[0].Colour} {((Motorcycle)vehicles[0]).KindOfMC}");
                            Console.WriteLine($"Spot {vehicles[1].ParkingSpot} {vehicles[1].RegNumber} {vehicles[1].Colour} {((Motorcycle)vehicles[1]).KindOfMC}");
                        }
                        else
                        {
                            Console.WriteLine($"Spot {vehicles[0].ParkingSpot} {vehicles[0].RegNumber} {vehicles[0].Colour} {((Motorcycle)vehicles[0]).KindOfMC}");
                        }
                    }
                    else if (vehicles[0] is Car)
                    {
                        Console.WriteLine($"Spot {vehicles[0].ParkingSpot} {vehicles[0].RegNumber} {vehicles[0].Colour} {((Car)vehicles[0]).Electric}");
                    }
                    else if (vehicles[0] is Buss && wasBuss == false)
                    {
                        wasBuss = true;
                        Console.WriteLine($"Spot {vehicles[0].ParkingSpot}-{vehicles[0].ParkingSpot + 1} {vehicles[0].RegNumber} {vehicles[0].Colour} {((Buss)vehicles[0]).AmountOfPassengers}");
                    }
                    else
                    {
                        wasBuss = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Spot {spots} empty");

                }

            }
        }
    }
}
