using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCA_FlightTicketReservation.Entities.Concrates;

namespace WCA_FlightTicketReservation.Services
{
    public class TicketServices
    {
        private static Dictionary<FlightInformation, Ticket> Tickets = new Dictionary<FlightInformation, Ticket>();
        public void BuyTicket(FlightInformation flight,Passenger passenger) 
        {
            Ticket ticket=new Ticket();
            ticket.Passenger = passenger;
            ticket.FlightInformation = flight;
            ticket.PnrNumber=Guid.NewGuid().ToString();
            ticket.LuggageCapacity=flight.Aircraft.CargoCapacity-flight.Aircraft.FuelCapacity/flight.Aircraft.PassengerCapacity;
            Tickets.Add(flight,ticket);
        }
        public void CancelTicket(string pnrNumber) 
        {
            Ticket ticketToCancel=Tickets.Values.Where(x=>x.PnrNumber==pnrNumber).FirstOrDefault();
            Tickets.Remove(ticketToCancel.FlightInformation);
        }
        public FlightInformation GetFlightInformation(string flighNumber) 
        {
            return FlightServices.GetFlightInformation().Where(x => x.FlightNumber==flighNumber).FirstOrDefault();
        }
    }
}
