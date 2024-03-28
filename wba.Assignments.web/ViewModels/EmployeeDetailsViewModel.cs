using wba.Assignments.core.entities;

namespace wba.Assignments.web.ViewModels
{
    public class EmployeeDetailsViewModel: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }
}
