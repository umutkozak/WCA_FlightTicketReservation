using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCA_FlightTicketReservation.Entities.Concrates;

namespace WCA_FlightTicketReservation.Services
{
    public class PlaneServices
    {
        private static List<Plane> Planes = new List<Plane>()
    {
        new Plane()
        {
            Brand = "Airbus",
            Model = "A319",
            ModelYear = 0,
            PassengerCapacity = 156,
            CargoCapacity = 0,
            TotalFlightWeightLimit = 79015,
            AircraftWeight = 41500,
            FuelCapacity = 26000
        },
        new Plane()
        {
            Brand = "Airbus",
            Model = "A320",
            ModelYear = 2015,
            PassengerCapacity = 150,
            CargoCapacity = 5000,
            AircraftWeight = 75000,
            TotalFlightWeightLimit = 100000,
            FuelCapacity = 30000
        },
        new Plane()
        {
            Brand = "Boeing",
            Model = "747",
            ModelYear = 2010,
            PassengerCapacity = 400,
            CargoCapacity = 10000,
            AircraftWeight = 120000,
            TotalFlightWeightLimit = 150000,
            FuelCapacity = 50000
        },
        new Plane()
        {
            Brand = "Embraer",
            Model = "E190",
            ModelYear = 2018,
            PassengerCapacity = 100,
            CargoCapacity = 3000,
            AircraftWeight = 50000,
            TotalFlightWeightLimit = 75000,
            FuelCapacity = 20000
        }
    };

        public List<Plane> GetPlaneList()
        {
            return Planes;
        }

        // Get plane information by name
        public Plane GetPlaneByName(string name)
        {
            return Planes.Where(x => x.Model == name).FirstOrDefault();
        }
    }
}
