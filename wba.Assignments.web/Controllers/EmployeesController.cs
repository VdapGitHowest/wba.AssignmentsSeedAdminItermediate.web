using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using wba.Assignments.core.entities;
using wba.Assignments.web.Data;
using wba.Assignments.web.ViewModels;

namespace wba.Assignments.web.Controllers
{
    public class EmployeesController : Controller
    {

        AssignmentDBContext _assignmentDBContext;

        public EmployeesController(AssignmentDBContext assignmentDBContext)
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
                .Include(e=>e.AssignedProjects)
                .FirstOrDefault(e => e.Id == id);

            //map data to viewmodel

            EmployeeDetailsViewModel employeeDetailsViewModel =
                new EmployeeDetailsViewModel
                {
                    Id = employee.Id,
                    Department = employee.Department,
                    Position = employee.Position,
                    Name = employee.Name,
                    //list the assigned projects of the selected employee
                    AssignedProjects = employee.AssignedProjects.Select(
                        assignedProject=> new ProjectDetailViewModel 
                        {
                            Name= assignedProject.Name,
                            StartDate = assignedProject.StartDate,
                            Id = assignedProject.Id
                        }).ToList()
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

            try
            {

                //fetch the to delete employee
                //use the value of parameter id
                Employee employee = _assignmentDBContext.Employees
                    .FirstOrDefault(e => e.Id == id);

                //Remove from Dbcontext
                _assignmentDBContext.Employees.Remove(employee);

                //update the Dbase
                _assignmentDBContext.SaveChanges();
            }
            catch
            {
                return View("Error");
            }


            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            //instance of employee to update
            //data of employee needed, because
            //form fiels must be filled in.

            Employee employee = _assignmentDBContext.Employees
                .FirstOrDefault(e => e.Id == id);

            EmployeeUpdateViewModel employeeUpdateViewModel = new EmployeeUpdateViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                Position = employee.Position
            };


            return View(employeeUpdateViewModel);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(EmployeeUpdateViewModel employeeUpdateViewModel)
        {
            //fetch the data on Employee ID
            //use the Id in the viewmodel as value for the id-field

            var updateEmployee = _assignmentDBContext.Employees
                .FirstOrDefault(e => e.Id == employeeUpdateViewModel.Id);
            //Update prop (postion, department) with new values out of viewmodel

            if (updateEmployee != null)
            {
                updateEmployee.Department = employeeUpdateViewModel.Department;
                updateEmployee.Position = employeeUpdateViewModel.Position;
            }

            //update database
            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
