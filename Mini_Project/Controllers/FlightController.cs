using Microsoft.AspNetCore.Mvc;
using AirlineReservationWeb.Models;

namespace AirlineReservationWeb.Controllers
{
    public class FlightController : Controller
    {
        private readonly AirlineContext db;
        public FlightController(AirlineContext _db)  //constructor
        {
            db = _db;
            //session = httpContextAccessor.HttpContext.Session;

        }
        public IActionResult FlightPage()
        {
            IEnumerable<Flight> objFlights = db.Flights.ToList();
            return View(objFlights);
        }
    }
}
