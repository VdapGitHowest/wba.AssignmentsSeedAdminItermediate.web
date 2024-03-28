using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using wba.Assignments.core.entities;
using wba.Assignments.web.Data;
using wba.Assignments.web.ViewModels;

namespace wba.Assignments.web.Controllers
{
    public class AssignmentsController : Controller
    {
        AssignmentDBContext _assignmentDBContext;

        public AssignmentsController(AssignmentDBContext assignmentDBContext)
        {
            _assignmentDBContext = assignmentDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add() 
        {
            AssignmentsAddViewModel assignmentsAddViewModel = new AssignmentsAddViewModel();

            //fetch projects from dbase

            var projects = _assignmentDBContext.Projects.ToList();

            var projectsList = projects.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList();

 
            //fetch employees from dbase

            var employees = _assignmentDBContext.Employees.Distinct();

            var employeeList = employees.Select(e => new SelectListItem
            {
                Value = e.Id.ToString(),
                Text = e.Name
            }).ToList();

            //assign projectsList to viewmodel
            assignmentsAddViewModel.Projects = projectsList;

            //assign employeeList to viewmodel
            assignmentsAddViewModel.Employees = employeeList;

            return View(assignmentsAddViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(AssignmentsAddViewModel assignmentsAddViewModel)
        {
            //add employees to existing project


            //fetch the project
            var project = _assignmentDBContext.Projects
    .FirstOrDefault(p => p.Id == assignmentsAddViewModel.SelectedProjectId);
            
            //make a instance of the assignedEmployees Icollection
           project.AssignedEmployees = new List<Employee>();

        
            //fetch the selectedEmployeeIDs
            var selectedEmployeeIds = assignmentsAddViewModel.SelectedEmployeeIds;

            //Loop in the list with selectedEmployeeIDs
            
            foreach(int id in selectedEmployeeIds)
            {
                var employee = _assignmentDBContext.Employees.Find(id);
                if (employee != null)
                {
                    //add this employee instance to ..........
                    project.AssignedEmployees.Add(employee);
                }

            }

            try
            {
                _assignmentDBContext.SaveChanges();

            }
            catch
            {
                return View("Error");
            }


            return RedirectToAction("Index");
        }


    }
}
