using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationWeb.Controllers
{
    public class CancelController : Controller
    {
        public IActionResult CancelPage()
        {
            return View();
        }
    }
}
