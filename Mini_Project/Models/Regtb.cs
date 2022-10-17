using System;
using System.Collections.Generic;

namespace AirlineReservationWeb.Models
{
    public partial class Regtb
    {
        public int Uid { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phonenumber { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
