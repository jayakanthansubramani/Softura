using Microsoft.AspNetCore.Mvc;
using AirlineReservationWeb.Models;
namespace AirlineReservationWeb.Controllers
{

    public class LoginController : Controller
    {
        private readonly AirlineContext db;
        //private readonly ISession session;
        public LoginController(AirlineContext _db)  //constructor
        {
            db = _db;
            //session = httpContextAccessor.HttpContext.Session;

        }
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(Regtb d)
        {
            var log = (from i in db.Regtbs//linq function used to select and cmd using in sql
                       where i.Login == d.Login && i.Password == d.Password
                       select i).SingleOrDefault();
            if (log != null)
            {
                //HttpContext.Session.SetString("uname", d.Login);
                return RedirectToAction("FlightPage", "Flight");
            }
            else
            {
                return View();
            }
            return View();
            
        }
        public IActionResult register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult register(Regtb e)
        {
            db.Regtbs.Add(e);
            db.SaveChanges();
            return RedirectToAction("userlogin");
        }


    }
}
