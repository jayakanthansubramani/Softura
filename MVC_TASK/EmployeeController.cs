using Microsoft.AspNetCore.Mvc;
using SampleApp.Models;

namespace SampleApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SingleEmpInfo()
        {
            List<Employee> emp = new()
            {
                new Employee()
                {
                    EmployeeID = 101,
                    Firstname = "Jaya",
                    Lastname = "Kanthan",
                    Gender = "Male",
                    City = "Vellore"
                }
            };
            ViewBag.List = emp;
            return View(emp);
        }

        public IActionResult AllEmpInfo()
        {
            List<Employee> emp = new()
            {
                new Employee()
                {
                    EmployeeID = 101,
                    Firstname = "Jaya",
                    Lastname = "Kanthan",
                    Gender = "Male",
                    City = "Vellore"
                },
                new Employee()
                {
                    EmployeeID = 102,
                    Firstname = "Dev",
                    Lastname = "Swamy",
                    Gender = "Male",
                    City = "Chennai"
                },
                new Employee()
                {
                    EmployeeID = 103,
                    Firstname = "Dhanush",
                    Lastname = "K",
                    Gender = "Male",
                    City = "Chennai"
                },
                new Employee()
                {
                    EmployeeID = 104,
                    Firstname = "Krishna",
                    Lastname = "M",
                    Gender = "Male",
                    City = "Chennai"
                },
                new Employee()
                {
                    EmployeeID = 105,
                    Firstname = "Ajay",
                    Lastname = "Rayen",
                    Gender = "Male",
                    City = "Chennai"
                },
            };
            return View(emp);
        }
        public IActionResult EnterNewInfo()
        {
            return View();
        }
    }
}
