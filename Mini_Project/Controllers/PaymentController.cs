using Microsoft.AspNetCore.Mvc;

namespace AirlineReservationWeb.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult PaymentPage()
        {
            return View();
        }
    }
}
