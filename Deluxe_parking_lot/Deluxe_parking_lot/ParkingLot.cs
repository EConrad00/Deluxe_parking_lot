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
        public double CurrentSize { get; set; }

        public int[] AvailableSpots{ get; set; }

        public Dictionary<int, List<Vehicle>> AvailableSpotsV2 { get; set; }

        public List<Vehicle> Vehicles { get; set; }
        public ParkingLot()
        {
            SizeOfParkingLot = 15;
            CurrentSize = 0;
            AvailableSpots = new int[30];
            AvailableSpotsV2 = new Dictionary<int, List<Vehicle>>();
            CreateSpots();
            Vehicles = new List<Vehicle>();
        }

        private void CreateSpots()
        {
            for (int i = 1; i < SizeOfParkingLot + 1; i++) 
            {
                AvailableSpotsV2.Add(i, new List<Vehicle>());
            }
        }
    }
}
