using System;
using System.Collections.Generic;

namespace AirlineReservationWeb.Models
{
    public partial class Flight
    {
        public int FlightId { get; set; }
        public string AirlineName { get; set; } = null!;
        public string FromLocation { get; set; } = null!;
        public string ToLocation { get; set; } = null!;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Duration { get; set; }
        public int TotalSeats { get; set; }
    }
}
