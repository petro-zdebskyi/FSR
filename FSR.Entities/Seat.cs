using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSR.Entities
{
    public class Seat
    {
        public Seat(Flight flight)
        {
            _flight = flight;
        }
        public int Id { get; set; }
        public int Number { get; set; }
        public string FlightDepature
        {
            get
            {
                return _flight.Depature;
            }
        }
        public string FlightDestination
        {
            get
            {
                return _flight.Destination;
            }
        }
        public decimal Cost { get; set; }
        public Flight GetFlightInfo()
        {
            return _flight;
        }
        private Flight _flight;
    }
}
