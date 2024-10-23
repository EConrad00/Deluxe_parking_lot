using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MainProgram
{
    static void Main(string[] args) 
    {
        while (true)
        {
            Console.WriteLine("[T]Test code\r\n" + "[E]xit\r\n");
            string key = Console.ReadKey().Key.ToString();
            switch (key) 
            {
                case "T":
                    break;
                case "E":
                    Console.Clear();
                    return;
            }

        }

    }
    

}
