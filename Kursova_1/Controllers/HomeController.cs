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
				TempData["success"] = "Дані успішно додано!";
				return RedirectToAction("Index");
            }
            return View(employee);
        }
		public IActionResult Info(int id)
		{
            var employee = _db.Employees.Find(id);
            return View(employee);
		}
        [HttpPost]
        public IActionResult Info(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Update(employee);
                _db.SaveChanges();
                TempData["success"] = "Дані успішно оновлено!";
                return RedirectToAction("Index");
            }
            return View(employee);
        }
		[HttpPost]
		public IActionResult Delete(int id)
		{
			var employee = _db.Employees.Find(id);
			if (ModelState.IsValid)
			{
                if (employee != null)
                {
                    _db.Employees.Remove(employee);
                    _db.SaveChanges();
                }
				TempData["success"] = "Дані успішно видалено!";
				return RedirectToAction("Index");
			}
			return View(employee);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
