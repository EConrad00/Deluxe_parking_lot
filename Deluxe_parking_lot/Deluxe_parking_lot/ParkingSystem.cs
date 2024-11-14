using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    internal class ParkingSystem
    {
        public static void CheckOut()
        {

        }

        public static void Park(ParkingLot parkingLot)
        {
            int rand = Random.Shared.Next(0, 3);

            if (rand == 0)
            {
                Car carA = new Car(Helper.CreateRegNumber(), "Red", false);
                carA.ParkingSpot = CheckAvailableSpots(parkingLot, carA);
                parkingLot.Vehicles.Add(carA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + carA.Size);
            }
            else if (rand == 1)
            {
                Buss bussA = new Buss(Helper.CreateRegNumber(), "Blue", 43);
                bussA.ParkingSpot = CheckAvailableSpots(parkingLot, bussA);
                parkingLot.Vehicles.Add(bussA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + bussA.Size);
            }
            else if (rand == 2)
            {
                Motorcycle motorcycleA = new Motorcycle(Helper.CreateRegNumber(), "Grey", "Harley");
                motorcycleA.ParkingSpot = CheckAvailableSpots(parkingLot, motorcycleA);
                parkingLot.Vehicles.Add(motorcycleA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + motorcycleA.Size);
            }
        }

        public static int CheckAvailableSpots(ParkingLot parkingLot,Vehicle vehicle)
        {
            int openSpot = 0;

            for (int i = 0; i < 30; i++)
            {

                if (vehicle is Car || (parkingLot.AvailableSpots[i] == 0 || parkingLot.AvailableSpots[i + 1] == 0))
                {
                    openSpot = i;
                    parkingLot.AvailableSpots[i] = i;
                    parkingLot.AvailableSpots[i + 1] = i;
                    break;
                }
                else if (vehicle is Motorcycle|| parkingLot.AvailableSpots[i] == 0)
                {
                    openSpot = i;
                    parkingLot.AvailableSpots[i] = i;
                    break;
                }
                else if (vehicle is Buss || (parkingLot.AvailableSpots[i] == 0 || parkingLot.AvailableSpots[i + 3] == 0))
                {
                    openSpot = i;
                    for (int j = i; j < i + 3; j++)
                    {
                        parkingLot.AvailableSpots[j] = i;
                    }
                    break;
                } 
            }
            return openSpot;
        }
    }
}
