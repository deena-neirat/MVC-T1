using Microsoft.AspNetCore.Mvc;
using Task1_WebApplication.Data;

namespace Task1_WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext Context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Emp = Context.Employees.ToList();
            return View("Index" , Emp);
        }
    }
}
