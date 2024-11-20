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
        //public static /*string*/ (string,string) GetUserInput(/*string newUserInput*/) 
        //{
        //    string newInput1 = "";
        //    string newInput2 = "";

        //    (string,string) correctInput = (newInput1,newInput2);
        //    return correctInput;
        //}
        public static (int,string,string) CreateVehicle()
        {
            int typeOfVehicle = Random.Shared.Next(0, 3);

            (string, string) finishedInput;
            if (typeOfVehicle == 0) 
            {
                finishedInput = Helper.CreateCar();
            }
            else if (typeOfVehicle == 1) 
            {
                 finishedInput = Helper.CreateBuss();
            }
            else
            {
                finishedInput = Helper.CreateMotorcycle();
            }
            //bool correct = true;
            //int localCheck = 0;
            //while (correct) 
            //{
            //    if (localCheck == 0 && correct == true)
            //    {

            //    }
            //    else if (localCheck == 1 && correct == true)
            //    {

            //    }
            //    else 
            //    {
            //        if(localCheck == 0)
            //        {
            //            Console.WriteLine("That is not a color, please input a color");
            //        }
            //        else
            //        {
            //            Console.WriteLine("That is not a color, please input a color");
            //        }
            //    }
            //}
            string input1 = finishedInput.Item1;
            string input2 = finishedInput.Item2;
            //for (int i = 0; i < 2; i++)
            //{
            //    string userInput = Helper.GetUserInput(newUserInput); 
            //}

            return (typeOfVehicle, input1, input2);
        }
        
        public static (string,string) CreateCar()
        {
            bool correct = true;
            int localCheck = 0;
            string correctInput1 = "";
            string correctInput2 = "";
            while (correct)
            {
                //string newInput = Console.ReadLine().ToUpper();
                if (localCheck == 0 && correct == true)
                {
                    Console.WriteLine("Please input a color: ");
                    string newInput = Console.ReadLine().ToUpper();
                    if (Helper.CheckColor(newInput) == false)
                    {
                        Console.WriteLine("That is not a color, please input a color");
                    }
                    else
                    {
                        localCheck++;
                        correctInput1 = newInput;
                    }
                }
                else if (localCheck == 1 && correct == true)
                {
                    Console.WriteLine("Please input yes or no for electical car: ");
                    string newInput = Console.ReadLine().ToUpper();
                    if (newInput == "YES")
                    {
                        correct = false;
                        correctInput2 = newInput;
                    }
                    else if (newInput == "NO")
                    {
                        correct = false;
                        correctInput2 = newInput;
                    }
                    else
                    {
                        Console.WriteLine("That is not a yes or no, please input a yes or no");
                    }

                }
                //else
                //{
                //    if (localCheck == 0)
                //    {
                //        Console.WriteLine("That is not a color, please input a color");
                //    }
                //    else
                //    {
                //        Console.WriteLine("That is not a yes or no, please input a yes or no");
                //    }
                //}
            }
            return (correctInput1,correctInput2);
        }

        public static (string, string) CreateBuss()
        {
            bool correct = true;
            int localCheck = 0;
            string correctInput1 = "";
            string correctInput2 = "";
            while (correct)
            {
                //string newInput = Console.ReadLine().ToUpper();
                if (localCheck == 0 && correct == true)
                {
                    Console.WriteLine("Please input a color: ");
                    string newInput = Console.ReadLine().ToUpper();
                    if (Helper.CheckColor(newInput) == false)
                    {
                        Console.WriteLine("That is not a color, please input a color");
                    }
                    else
                    {
                        localCheck++;
                        correctInput1 = newInput;
                    }
                }
                else if (localCheck == 1 && correct == true)
                {
                    Console.WriteLine("Please input how many passangers: ");
                    string newInput = Console.ReadLine().ToUpper();
                    if (int.TryParse(newInput, out int num))
                    {
                        correct = false;
                        correctInput2 = num.ToString();
                    }
                    else
                    {
                        Console.WriteLine("That is not a number, please input a number");
                    }

                }
                //else
                //{
                //    if (localCheck == 0)
                //    {
                //        Console.WriteLine("That is not a color, please input a color");
                //    }
                //    else
                //    {
                //        Console.WriteLine("That is not a yes or no, please input a yes or no");
                //    }
                //}
            }
            return (correctInput1, correctInput2);
        }

        public static (string, string) CreateMotorcycle()
        {
            bool correct = true;
            int localCheck = 0;
            string correctInput1 = "";
            string correctInput2 = "";
            while (correct)
            {
                //string newInput = Console.ReadLine().ToUpper();
                if (localCheck == 0 && correct == true)
                {
                    Console.WriteLine("Please input a color: ");
                    string newInput = Console.ReadLine().ToUpper();
                    if (Helper.CheckColor(newInput) == false)
                    {
                        Console.WriteLine("That is not a color, please input a color");
                    }
                    else
                    {
                        localCheck++;
                        correctInput1 = newInput;
                    }
                }
                else if (localCheck == 1 && correct == true)
                {
                    Console.WriteLine("Please input a what kind of motorcycle: ");
                    string newInput = Console.ReadLine().ToUpper();
                    if (int.TryParse(newInput, out int num))
                    {
                        Console.WriteLine("That is a number, please input a type of motorcycle");
                    }
                    else
                    {
                        correctInput2 = newInput;
                        correct = false;
                    }

                }
                //else
                //{
                //    if (localCheck == 0)
                //    {
                //        Console.WriteLine("That is not a color, please input a color");
                //    }
                //    else
                //    {
                //        Console.WriteLine("That is not a yes or no, please input a yes or no");
                //    }
                //}
            }
            return (correctInput1, correctInput2);
        }
        public static bool CheckColor(string inputToCheck)
        {
            bool trueFalse = false;
            List<string> colors = new List<string>() {"Red : Röd","Blue : Blå","Green : Grön","Yellow : Gul","Orange", "Purple : lila", "Pink : Rosa" };
            string found = colors.Find(x => inputToCheck == x);
            if (found != string.Empty) 
            {
                trueFalse = true;
            }
            //foreach (var color in colors)
            //{
                
            //}
            return trueFalse;
        }

        public static void IncParkingPrice(ParkingLot parkingLot)
        {
            foreach (var currParkingSpot in parkingLot.AvailableSpotsV2.Keys)
            {
                parkingLot.AvailableSpotsV2.TryGetValue(currParkingSpot, out List<Vehicle> vehicles);

                if (vehicles.Count != 0)
                {
                    foreach (var vehicle in vehicles)
                    {
                        vehicle.ParkingPrice += 1.5;
                    }
                }
            }
        }
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
                        if (((Car)vehicles[0]).Electric == true)
                        {
                            Console.WriteLine($"Spot {vehicles[0].ParkingSpot} {vehicles[0].RegNumber} {vehicles[0].Colour} Elbil"); 
                        }
                        else
                        {
                            Console.WriteLine($"Spot {vehicles[0].ParkingSpot} {vehicles[0].RegNumber} {vehicles[0].Colour} inte Elbil");
                        }
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
