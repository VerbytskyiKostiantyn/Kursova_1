using Kursova_1.Models;
using Kursova_1.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Kursova_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ManageEmployeesDbContext _db;
        public HomeController(ILogger<HomeController> logger, ManageEmployeesDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _db.Employees.ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }
		[HttpPost]
		public IActionResult Create(Employee employee)
		{
            if (ModelState.IsValid)
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
		public IActionResult Info()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
