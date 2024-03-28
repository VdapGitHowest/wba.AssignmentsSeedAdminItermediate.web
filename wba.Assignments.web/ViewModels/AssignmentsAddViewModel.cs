using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace wba.Assignments.web.ViewModels
{
    public class AssignmentsAddViewModel
    {
        //... ??????????
        //list of Projects =>listbox =>(selectedProjectID, Projects)
        [Required]
        [Display(Name ="Project")]
        public int SelectedProjectId { get; set; }
        public List<SelectListItem>Projects { get; set; }

        //list of Employee =>listbox =>(selectedEmployeeID, Employees)
        [Required]
        [Display(Name = "Employee")]

        //multiple employeeId's store in list, array,...
        public List<int> SelectedEmployeeIds { get; set; }
        public List<SelectListItem> Employees { get; set; }

    }
}
