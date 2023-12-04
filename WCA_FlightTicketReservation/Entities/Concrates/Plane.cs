using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_FlightTicketReservation.Entities.Concrates
{
    public class Plane
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public int PassengerCapacity { get; set; }
        public int CargoCapacity { get; set; }
        public int AircraftWeight { get; set; }
        public int TotalFlightWeightLimit { get; set; }
        public int FuelCapacity { get; set; }
    }
}
