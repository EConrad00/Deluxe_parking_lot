﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    internal class ParkingSystem
    {
        public static void CheckOut(ParkingLot parkingLot, string vehicleToCheckOut)
        {

            foreach (var currParkingSpot in parkingLot.AvailableSpotsV2.Keys)
            {
                parkingLot.AvailableSpotsV2.TryGetValue(currParkingSpot, out List<Vehicle> vehicles);

                if (vehicles.Count != 0)
                {
                    foreach (var vehicle in vehicles)
                    {
                        if (vehicle.RegNumber == vehicleToCheckOut)
                        {
                            Console.WriteLine($"{vehicle.RegNumber} was checked out");
                            parkingLot.CurrentSize -= vehicle.Size;
                            vehicles.Remove(vehicle);
                            break;
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Please write a valid regnumber");
                    break;
                }

            }
        }

        public static void Park(ParkingLot parkingLot)
        {
            int rand = Random.Shared.Next(0, 3);

            if (rand == 0 && parkingLot.CurrentSize <= 14)
            {
                Car carA = new Car(Helper.CreateRegNumber(), "Red", false);
                carA.ParkingSpot = CheckAvailableSpotsV2(parkingLot, carA);
                //parkingLot.Vehicles.Add(carA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + carA.Size);
            }
            else if (rand == 1 && parkingLot.CurrentSize <= 13)
            {
                Buss bussA = new Buss(Helper.CreateRegNumber(), "Blue", 43);
                bussA.ParkingSpot = CheckAvailableSpotsV2(parkingLot, bussA);
                //parkingLot.Vehicles.Add(bussA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + bussA.Size);
            }
            else if (rand == 2)
            {
                Motorcycle motorcycleA = new Motorcycle(Helper.CreateRegNumber(), "Grey", "Harley");
                motorcycleA.ParkingSpot = CheckAvailableSpotsV2(parkingLot, motorcycleA);
                //parkingLot.Vehicles.Add(motorcycleA);
                parkingLot.CurrentSize = (parkingLot.CurrentSize + motorcycleA.Size);
            }
            else
            {
                // Move to display
                string vehicle = "";
                if (rand == 0) 
                {
                    vehicle = "car";
                }
                else
                {
                    vehicle = "buss";
                }
                Console.WriteLine($"There is not room for a {vehicle} of that size");
            }
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
                else if (vehicle is Motorcycle) //Can be cleaned up, second if statement not neccesary
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
            }
            return isParkedHere;
        }
    }
}
