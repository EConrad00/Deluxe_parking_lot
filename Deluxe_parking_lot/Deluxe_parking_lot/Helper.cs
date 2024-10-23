using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluxe_parking_lot
{
    internal class Helper
    {
        public ParkingLot CreateLot()
        {
            List<Vehicle> vehicles = [];
            ParkingLot parkingLot = new (vehicles);
            return parkingLot;
        }
    }
}
