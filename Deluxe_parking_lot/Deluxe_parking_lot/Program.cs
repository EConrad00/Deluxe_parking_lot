using Deluxe_parking_lot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MainProgram
{
    static void Main(string[] args) 
    {
        Helper helper = new Helper();
        //ParkingLot parking_lot = helper.CreateLot();
        ParkingLot parking_lot = new ParkingLot();
        while (true)
        {
            Console.WriteLine("[T]Time passes\r\n" + "[C]Checkout a vehicle\r\n" + "[E]xit\r\n");
            string key = Console.ReadKey().Key.ToString();
            switch (key) 
            {
                case "T":
                    Console.Clear();
                    //Console.WriteLine($"{carA.RegNumber} {carA.Colour} {carA.Electric}");
                    if(parking_lot.SizeOfParkingLot > parking_lot.CurrentSize)
                    {
                        //helper.CreateVehicle(parking_lot);
                        ParkingSystem.Park(parking_lot);
                        Helper.DisplayCurrentLotV2(parking_lot);
                        Console.WriteLine($"Parkinlot is this full {parking_lot.CurrentSize}");
                    }
                    else
                    {
                        //helper.CheckOut(parking_lot);
                        Helper.DisplayCurrentLotV2(parking_lot);
                        Console.WriteLine($"Parkinlot is full {parking_lot.CurrentSize}");
                    }
                    
                    break;
                case "C":
                    string regNrFromAdmin = Console.ReadLine().ToUpper();
                    ParkingSystem.CheckOut(parking_lot, regNrFromAdmin);
                    Console.Clear();
                    Helper.DisplayCurrentLotV2(parking_lot);
                    Console.WriteLine($"Parkinlot is this full {parking_lot.CurrentSize}");
                    break;
                case "E":
                    Console.Clear();
                    return;
            }

        }

    }
    

}
