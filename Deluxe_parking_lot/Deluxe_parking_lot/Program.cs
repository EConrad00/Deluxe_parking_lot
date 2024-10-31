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
            Console.WriteLine("[T]Test code\r\n" + "[E]xit\r\n");
            string key = Console.ReadKey().Key.ToString();
            switch (key) 
            {
                case "T":
                    Console.Clear();
                    //Console.WriteLine($"{carA.RegNumber} {carA.Colour} {carA.Electric}");
                    if(parking_lot.SizeOfParkingLot > helper.CurrentSize)
                    {
                        helper.CreateVehicle(parking_lot);
                        helper.DisplayCurrentLot(parking_lot);
                        Console.WriteLine($"Parkinlot is this full {helper.CurrentSize}");
                    }
                    else
                    {
                        helper.DisplayCurrentLot(parking_lot);
                        Console.WriteLine($"Parkinlot is full {helper.CurrentSize}");
                    }
                    
                    break;
                case "E":
                    Console.Clear();
                    return;
            }

        }

    }
    

}
