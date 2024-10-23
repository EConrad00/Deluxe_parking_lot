using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    internal class Helper
    {
        public void CreateLot()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            ParkingLot parkingLot = new ParkingLot(vehicles);
        }
    }
}
