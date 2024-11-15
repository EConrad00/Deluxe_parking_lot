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
            int openSpot = 31;
            double test = 0;


            if (vehicle is Car)
            {

                for (int i = 0; i < 29; i++)
                {
                    
                    test = (i / 2);
                    //Console.WriteLine(test);
                    if ((parkingLot.AvailableSpots[i] == 0  && parkingLot.AvailableSpots[i + 1] == 0) && ((openSpot = (int)Math.Round(test)) != 0))
                    {
                        //Console.WriteLine((i / 2));
                        openSpot = (i / 2);
                        parkingLot.AvailableSpots[i] = i;
                        parkingLot.AvailableSpots[i + 1] = i;
                        return openSpot; 
                    }
                    else
                    {
                        openSpot = 1;
                        //return openSpot;
                    }
                }
            }
            else if (vehicle is Motorcycle)
            {

                for (int i = 0; i < 30; i++)
                {
                    if (parkingLot.AvailableSpots[i] == 0 && (openSpot = i / 2) != 0)
                    {
                        if((openSpot = i / 2) == 0)
                        {
                            openSpot = 1;
                        }
                        else if (parkingLot.AvailableSpots[i - 1] == parkingLot.AvailableSpots[i - 2])
                        {
                            openSpot = i / 2;
                            parkingLot.AvailableSpots[i] = i;
                        }
                        else
                        {
                            openSpot = (i / 2);
                            parkingLot.AvailableSpots[i] = i - 1;
                        }
                        return openSpot;
                    }
                    else
                    {
                        openSpot = 1;
                        //return openSpot;
                    }
                    //break; 
                }
            }
            else if (vehicle is Buss)
            {
                for (int i = 0; i < 27; i++)
                {
                    if ((parkingLot.AvailableSpots[i] == 0 && parkingLot.AvailableSpots[i + 3] == 0) && (openSpot = (i + 1) / 2) != 0)
                    {
                        openSpot = (i + 1) / 2;
                        for (int j = i; j < i + 3; j++)
                        {
                            parkingLot.AvailableSpots[j] = i;
                        }
                        return openSpot;  
                    }
                    else
                    {
                        openSpot = 1;
                        //return openSpot;
                    }
                }
            }
            //Console.WriteLine(openSpot);
            return openSpot;
        }
    }
}
