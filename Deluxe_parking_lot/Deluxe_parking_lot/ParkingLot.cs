using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    public class ParkingLot
    {
        public double SizeOfParkingLot { get; }

        public List<Vehicle> Vehicles { get; set; }
        public ParkingLot()
        {
            SizeOfParkingLot = 15;
            Vehicles = new List<Vehicle>();
        }
    }
}
