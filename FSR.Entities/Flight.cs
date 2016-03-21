using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSR.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public DateTime DepatureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Depature { get; set; }
        public string Destination { get; set; }
    }
}
