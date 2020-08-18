using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationMVCW5._BLL.Models;
using WebApplicationMVCW5._BLL.Services;
using WebApplicationMVCW5.Models;

namespace WebApplicationMVCW5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _employeeService;
        public HomeController(ILogger<HomeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public ActionResult EmployeeList()
        {
            var employeeBModels = _employeeService.FetchAll();

            var vmList = new List<EmployeeViewModel>();
            foreach (var item in employeeBModels)
            {
                var vmEmployee = new EmployeeViewModel();

                vmEmployee.Id = item.EmployeeId;
                vmEmployee.Name = item.Name.ToUpper();
                vmEmployee.Salary = item.Salary; //.ToString();
                vmEmployee.IsRetired = item.IsRetired;

                if (item.Salary > 5)
                {
                    vmEmployee.SalaryColor = "green";
                }
                else
                {
                    vmEmployee.SalaryColor = "red";
                }
                vmList.Add(vmEmployee);
            }

            return View(vmList);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                //add to business layer
                var emplyeeBModel = new EmployeeBLLModel();
                emplyeeBModel.Name = model.Name;
                emplyeeBModel.Salary = model.Salary;
                emplyeeBModel.IsRetired = model.IsRetired;
                _employeeService.Add(emplyeeBModel);

                return RedirectToAction("EmployeeList");
            }

            return View(model);
        }
    }
}
