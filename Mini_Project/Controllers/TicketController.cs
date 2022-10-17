using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationWeb.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult TicketPage()
        {
            return View();
        }
    }
}
