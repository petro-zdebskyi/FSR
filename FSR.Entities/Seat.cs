using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSR.Entities
{
    public class Seat
    {
        #region Constructors

        public Seat(Flight flight)
        {
            _flight = flight;
        }

        #endregion

        #region Properties

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

        #endregion

        #region Methods

        public Flight GetFlightInfo()
        {
            return _flight;
        }

        #endregion

        #region Private Fields

        private Flight _flight;

        #endregion
    }
}
