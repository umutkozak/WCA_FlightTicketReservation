using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCA_FlightTicketReservation.Entities.Concrates
{
    public class Ticket
    {
        public FlightInformation FlightInformation { get; set; }
        public Passenger Passenger { get; set; }
        public string PnrNumber { get; set; }
        public int LuggageCapacity { get; set; }
    }
}
