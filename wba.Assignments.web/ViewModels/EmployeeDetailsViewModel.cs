using wba.Assignments.core.entities;

namespace wba.Assignments.web.ViewModels
{
    public class EmployeeDetailsViewModel: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        //projects assigned to employee
        //Do not refer to an entity in a viewmodel (hard coppling)
        //solution, add an viewmodel with the prop neeeded 
        //use the vm as type for the ICollection

        public ICollection<ProjectDetailViewModel> AssignedProjects { get; set; }


    }
}
