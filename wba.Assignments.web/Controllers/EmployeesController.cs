using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wba.Assignments.core.entities;
using wba.Assignments.web.Data;
using wba.Assignments.web.ViewModels;

namespace wba.Assignments.web.Controllers
{
    public class EmployeesController : Controller
    {

        AssignmentDBContext _assignmentDBContext;

        public EmployeesController( AssignmentDBContext assignmentDBContext)
        {
            _assignmentDBContext = assignmentDBContext;

        }

        public IActionResult Index()
        {
       var employees = _assignmentDBContext.Employees.ToList();

            EmployeeIndexViewModel employeeIndexViewModel = new EmployeeIndexViewModel
            {
                Employees = employees.Select(e => new EmployeeDetailsViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Department = e.Department,
                    Position = e.Position

                }).ToList(),
            };

            //list of employees
            return View(employeeIndexViewModel);
        }

                public IActionResult Details(int id)
        {
            //1 employee (selected by id)
            //fetch data from DBcontext instance
            //use Linq
            var employee = _assignmentDBContext.Employees
                .FirstOrDefault(e => e.Id == id);

            //map data to viewmodel

            EmployeeDetailsViewModel employeeDetailsViewModel =
                new EmployeeDetailsViewModel
                {
                    Id = employee.Id,
                    Department = employee.Department,
                    Position = employee.Position,
                    Name = employee.Name
                };

           
            return View(employeeDetailsViewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            EmployeeAddViewModel employeeAddViewModel = new EmployeeAddViewModel();

            return View(employeeAddViewModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Add(EmployeeAddViewModel employeeAddViewModel)
        {
            //new object with values out of form inputs

            Employee employee = new Employee
            {
                Created = DateTime.UtcNow,
                Name = employeeAddViewModel.Name,
                Department = employeeAddViewModel.Department,
                Position = employeeAddViewModel.Position,
                

            };
            //update the dbContext with the ne object
            _assignmentDBContext.Employees.Add(employee);
            //update the database with the new dbContext changes
            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            //fetch the to delete empoyee

            Employee employee = _assignmentDBContext.Employees
                .FirstOrDefault(e=>e.Id == id);

            //Remove this object from the DBcontext
            _assignmentDBContext.Employees.Remove(employee);
            //update the database with the new dbContext changes
            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
