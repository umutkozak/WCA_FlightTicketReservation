using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCA_FlightTicketReservation.Entities.Concrates;
using WCA_FlightTicketReservation.Enums;

namespace WCA_FlightTicketReservation.Services
{
    public class FlightServices
    {
        private static List<FlightInformation> Flights = new List<FlightInformation>()
    {
        new FlightInformation()
        {
            DepartureLocation = "Istanbul",
            ArrivalLocation = "Paris",
            Aircraft = new PlaneServices().GetPlaneByName("A319"),
            Time = new TimeOnly(8, 0), // Set as an example time of 08:00.
            FlightDate = new DateTime(2023, 12, 1), // Set as an example date of December 1, 2023.
            FlightDuration = 180, // Set as an example flight duration in minutes as 180.
            FlightNumber = "TK123",
            GateNumber = "GATE A12",
            EmptySeats = 120,
            Status = FlightStatus.CounterOpen,
            PromoSeatsCount = 10
        },

        new FlightInformation()
        {
            DepartureLocation = "New York",
            ArrivalLocation = "London",
            Aircraft = new PlaneServices().GetPlaneByName("A320"),
            Time = new TimeOnly(14, 30), // Set as an example time of 14:30.
            FlightDate = new DateTime(2023, 12, 5), // Set as an example date of December 5, 2023.
            FlightDuration = 360, // Set as an example flight duration in minutes as 360.
            FlightNumber = "BA456",
            GateNumber = "GATE B6",
            EmptySeats = 200,
            Status = FlightStatus.Departed,
            PromoSeatsCount = 20
        },

        new FlightInformation()
        {
            DepartureLocation = "Tokyo",
            ArrivalLocation = "Sydney",
            Aircraft = new PlaneServices().GetPlaneByName("747"),
            Time = new TimeOnly(20, 45), // Set as an example time of 20:45.
            FlightDate = new DateTime(2023, 12, 10), // Set as an example date of December 10, 2023.
            FlightDuration = 600, // Set as an example flight duration in minutes as 600.
            FlightNumber = "JL789",
            GateNumber = "GATE C3",
            EmptySeats = 80,
            Status = FlightStatus.Delayed,
            PromoSeatsCount = 5
        }
    };

        public static List<FlightInformation> GetFlightInformation()
        {
            return Flights;
        }
    }

}
