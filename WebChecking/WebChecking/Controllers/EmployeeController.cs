using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebChecking.Models;
using WebChecking.ViewModel;

namespace WebChecking.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext _context;
		public EmployeeController()
		{
            _context = new ApplicationDbContext();
		}
        // GET: Employee
        public ActionResult Index()
        {
            return RedirectToAction("Index","Home");
        }

        public ActionResult Create()
        {
            var departments = _context.Departments.ToList();
            var dropDepartment = new EmployeeDepartmentViewModel
            {
                Departments=departments
            };
            return View(dropDepartment);
        }
        [HttpPost]

        public ActionResult Create(Employee emp)
        {
            //_context.Employees.Add(emp);
            //_context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        
    }
}