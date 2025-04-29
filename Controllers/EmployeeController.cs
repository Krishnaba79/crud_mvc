using Microsoft.AspNetCore.Mvc;
using crud_mvc.Models;

namespace crud_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        // HTTP GET VERSION


        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult Create(Employee Employee)
        {
            Repository.Create(Employee);
            return View("Thanks", Employee);
        }
        public IActionResult Index()
        {
            return View(Repository.AllEmpoyees);
        }
        public IActionResult Update(string empname)
        {
            Employee Employee = Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault();
            return View(Employee);
        }

        [HttpPost]
        public IActionResult Update(Employee Employee, string empname)
        {
            Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Age = Employee.Age;
            Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Salary = Employee.Salary;
            Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Department = Employee.Department;
            Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Gender = Employee.Gender;
            Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault().Name = Employee.Name;

            return RedirectToAction("Index");
        }
        public IActionResult Delete(string empname)
        {
            Employee Employee = Repository.AllEmpoyees.Where(e => e.Name == empname).FirstOrDefault();
            Repository.Delete(Employee);
            return RedirectToAction("Index");
        }
    }
}
