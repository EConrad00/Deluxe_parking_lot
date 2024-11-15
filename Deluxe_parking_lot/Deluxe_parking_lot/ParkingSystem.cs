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

            if (rand == 0 && parkingLot.CurrentSize <= 14)
            {
                Car carA = new Car(Helper.CreateRegNumber(), "Red", false);
                //carA.ParkingSpot = CheckAvailableSpots(parkingLot, carA);
                carA.ParkingSpot = CheckAvailableSpotsV2(parkingLot, carA);
                parkingLot.Vehicles.Add(carA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + carA.Size);
            }
            else if (rand == 1 && parkingLot.CurrentSize <= 13)
            {
                Buss bussA = new Buss(Helper.CreateRegNumber(), "Blue", 43);
                //bussA.ParkingSpot = CheckAvailableSpots(parkingLot, bussA);
                bussA.ParkingSpot = CheckAvailableSpotsV2(parkingLot, bussA);
                parkingLot.Vehicles.Add(bussA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + bussA.Size);
            }
            else if (rand == 2)
            {
                Motorcycle motorcycleA = new Motorcycle(Helper.CreateRegNumber(), "Grey", "Harley");
                //motorcycleA.ParkingSpot = CheckAvailableSpots(parkingLot, motorcycleA);
                motorcycleA.ParkingSpot = CheckAvailableSpotsV2(parkingLot, motorcycleA);
                parkingLot.Vehicles.Add(motorcycleA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + motorcycleA.Size);
            }
            else
            {
                //Write something about being unable to park such a big vehicle
            }
        }

        public static int CheckAvailableSpots(ParkingLot parkingLot, Vehicle vehicle)
        {
            int openSpot = 31;
            double test = 0;


            if (vehicle is Car)
            {

                for (int i = 0; i < 29; i++)
                {

                    test = (i / 2);
                    //Console.WriteLine(test);
                    if ((parkingLot.AvailableSpots[i] == 0 && parkingLot.AvailableSpots[i + 1] == 0) && ((openSpot = (int)Math.Round(test)) != 0))
                    {
                        //Console.WriteLine((i / 2));
                        openSpot = (i / 2);
                        parkingLot.AvailableSpots[i] = i;
                        parkingLot.AvailableSpots[i + 1] = i;
                        return openSpot + 1;
                    }
                    else if ((openSpot = (int)Math.Round(test)) == 0 && parkingLot.AvailableSpots[0] == 0)
                    {
                        openSpot = 1;
                        parkingLot.AvailableSpots[i] = i + 1;
                        parkingLot.AvailableSpots[i + 1] = i + 1;
                        break;
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

                        if (parkingLot.AvailableSpots[i - 1] == parkingLot.AvailableSpots[i - 2] || parkingLot.AvailableSpots[i - 1] == parkingLot.AvailableSpots[(i - 3)])
                        {
                            openSpot = i / 2;
                            parkingLot.AvailableSpots[i] = i;
                        }
                        else
                        {
                            openSpot = (i / 2);
                            parkingLot.AvailableSpots[i] = i - 1;
                        }
                        return openSpot + 1;
                    }
                    else if ((openSpot = i / 2) == 0 && parkingLot.AvailableSpots[0] == 0)
                    {
                        openSpot = 1;
                        parkingLot.AvailableSpots[i] = i + 1;
                        break;
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
                        return openSpot + 1;
                    }
                    else if ((openSpot = (i + 1) / 2) == 0 && parkingLot.AvailableSpots[0] == 0)
                    {
                        openSpot = 1;
                        for (int j = i; j < i + 3; j++)
                        {
                            parkingLot.AvailableSpots[j] = i + 1;
                        }
                        break;
                        //return openSpot;
                    }
                }
            }
            //Console.WriteLine(openSpot);
            return openSpot;
        }

        public static int CheckAvailableSpotsV2(ParkingLot parkingLot, Vehicle vehicle)
        {
            int i = 0;
            int isParkedHere = 0;
            foreach (var currParkingSpot in parkingLot.AvailableSpotsV2.Keys)
            {
                parkingLot.AvailableSpotsV2.TryGetValue(currParkingSpot, out List<Vehicle> vehicles);
                if (vehicles.Count == 0 && vehicle is Buss)
                {
                    i++;
                }
                if (vehicle is Car && vehicles.Count == 0)
                {
                    vehicles.Add(vehicle);
                    parkingLot.AvailableSpotsV2[currParkingSpot] = vehicles;
                    isParkedHere = currParkingSpot;
                    break;
                }
                else if (vehicle is Buss && i == 2)
                {
                    vehicles.Add(vehicle);
                    parkingLot.AvailableSpotsV2[currParkingSpot - 1] = vehicles;
                    parkingLot.AvailableSpotsV2[currParkingSpot] = vehicles;
                    isParkedHere = currParkingSpot - 1;
                    break;
                }
                else if (vehicle is Motorcycle)
                {
                    if (vehicles.Count == 1 && vehicles[0] is Motorcycle)
                    {
                        vehicles.Add(vehicle);
                        parkingLot.AvailableSpotsV2[currParkingSpot] = vehicles;
                        isParkedHere = currParkingSpot;
                        break;
                    }
                    else if(vehicles.Count == 0)
                    {
                        vehicles.Add(vehicle);
                        parkingLot.AvailableSpotsV2[currParkingSpot] = vehicles;
                        isParkedHere = currParkingSpot;
                        break;
                    }
                }
                //i++;
            }
            return isParkedHere;
        }
    }
}
