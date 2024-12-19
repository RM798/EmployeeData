//using EmployeeData.Models;
//using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;

//namespace EmployeeData.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ILogger<HomeController> _logger;

//        public HomeController(ILogger<HomeController> logger)
//        {
//            _logger = logger;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new EmployeeDataModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}

using EmployeeData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Home/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Home/Save
    [HttpPost]
    //[ValidateAntiForgeryToken]
    public EmployeeModel Save(EmployeeModel details)
    {
        EmployeeModel newdata = new EmployeeModel();
        newdata.EmployeeCode = details.EmployeeCode;
        newdata.EmployeeName = details.EmployeeName;
        newdata.BasicSalary = details.BasicSalary;
        newdata.DateOfBirth = details.DateOfBirth;
        newdata.Department = details.Department;
        newdata.Designation = details.Designation;
        newdata.Gender = details.Gender;    

        if (ModelState.IsValid)
        {
            _context.Employees.Add(newdata); // Add to context
            _context.SaveChanges();          // Save changes to database
            /*return RedirectToAction("Index");*/ // Redirect to a confirmation page or list
        }

        return newdata; // Return to the form if validation fails
    }

    // GET: Employee/Index
    public ActionResult Index()
    {
        var employees = _context.Employees.ToList();
        return View(employees); // Display the list of employees
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
        base.Dispose(disposing);
    }
}