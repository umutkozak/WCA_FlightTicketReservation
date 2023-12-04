using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCA_FlightTicketReservation.Enums;

namespace WCA_FlightTicketReservation.Entities.Concrates
{
    public class Passenger
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }
        public int Age { get; set; }
        public string IdentificationNumber { get; set; }
        public string PassportNumber { get; set; }
    }
}
