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
        ParkingLot parking_lot = helper.CreateLot();
        while (true)
        {
            Console.WriteLine("[T]Test code\r\n" + "[E]xit\r\n");
            string key = Console.ReadKey().Key.ToString();
            switch (key) 
            {
                case "T":
                    Console.Clear();
                    Console.WriteLine($"{parking_lot.SizeOfParkingLot}");
                    break;
                case "E":
                    Console.Clear();
                    return;
            }

        }

    }
    

}
