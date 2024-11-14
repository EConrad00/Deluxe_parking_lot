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
                Car carA = new Car(Helper.CreateRegNumber(), "Red", CheckAvailableSpots(parkingLot), false);
                parkingLot.Vehicles.Add(carA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + carA.Size);
            }
            else if (rand == 1)
            {
                Buss bussA = new Buss(Helper.CreateRegNumber(), "Blue", CheckAvailableSpots(parkingLot), 43);
                parkingLot.Vehicles.Add(bussA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + bussA.Size);
            }
            else if (rand == 2)
            {
                Motorcycle motorcycleA = new Motorcycle(Helper.CreateRegNumber(), "Grey", CheckAvailableSpots(parkingLot), "Harley");
                parkingLot.Vehicles.Add(motorcycleA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + motorcycleA.Size);
            }
        }

        public static int CheckAvailableSpots(ParkingLot parkingLot)
        {
            int openSpot = 0;
            return openSpot;
        }
    }
}
