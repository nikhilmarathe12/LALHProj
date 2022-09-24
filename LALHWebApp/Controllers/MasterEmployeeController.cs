using LHLAApplication.Interfaces;
using LHLAApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LALHWebApp.Controllers
{
    public class MasterEmployeeController : Controller
    {
        private IEmployeeService _employeeService;

        public MasterEmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            VMEmployee employee = _employeeService.GetMasterEmployees();

            return View(employee);
        }
    }
}
