using Microsoft.AspNetCore.Mvc;

namespace wba.Assignments.web.ViewModels
{
    public class ProjectDetailViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

    }
}
