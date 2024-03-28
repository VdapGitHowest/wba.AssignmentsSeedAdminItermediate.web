using Microsoft.EntityFrameworkCore;
using wba.Assignments.core.entities;

namespace wba.Assignments.web.Data
{
    public class DataSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            //seeding Data

            //Employees (PT)

            var employees = new Employee[]
            {
                new Employee{ Id = 1,Name="Peter Van Damme",Department="IT",
                Position="Developer",Created=DateTime.UtcNow},
                 new Employee{ Id = 2,Name="Lars Pollentier",Department="IT",
                Position="Analyst",Created=DateTime.UtcNow},
                  new Employee{ Id = 3,Name="Wannes Vantorre",Department="IT",
                Position="Virtual machine specialist",Created=DateTime.UtcNow},
                   new Employee{ Id = 4,Name="Kristof",Department="IT",
                Position="Developer",Created=DateTime.UtcNow},

            };




            //Projects (PT)
            var projects = new Project[]

            {
                new Project
                {
                    Id=1,
                    Name="Website Redesign",
                    Description="Redesining the company website to improve AI capabilities",
                    StartDate=new DateTime(2024,4,1),
                    EndDate=new DateTime(2024,10,12),
                    Created=DateTime.UtcNow
                },
                  new Project
                {
                    Id=2,
                    Name="Product launch",
                    Description="Launching a new product with expensive marketing campaign",
                    StartDate=new DateTime(2024,10,1),
                    EndDate=new DateTime(2025,5,12),
                    Created=DateTime.UtcNow
                },
                    new Project
                {
                    Id=3,
                    Name="Internal Training Program",
                    Description="Implementing a training program for employees to enhance skills and productivity.",
                    StartDate=new DateTime(2024,5,1),
                    EndDate=new DateTime(2024,9,24),
                    Created=DateTime.UtcNow
                },
            };



            //EmployeeProject (FT)
            //keys in DB not in classe ==> Anonymous class
            //look for names of keys in DB table.
            //combination of values must be unique

            var employeeProjects = new[]
            {
                 new{AssignedEmployeesId = 1, AssignedProjectsId=3},
                 new{AssignedEmployeesId = 2, AssignedProjectsId=3},
                new{AssignedEmployeesId = 3, AssignedProjectsId=3},
                new{AssignedEmployeesId = 4, AssignedProjectsId=3},
                new{AssignedEmployeesId = 1, AssignedProjectsId=2},
                new{AssignedEmployeesId = 1, AssignedProjectsId=1},
        
             };

             modelBuilder.Entity<Employee>().HasData(employees);
            modelBuilder.Entity<Project>().HasData(projects);
            //look at junction table in Db (EmployeeProject)
            //Construct the name of the DB with the name of the Primary tables (Employee Project)
            //add the hasdata method with the correct datalist
            modelBuilder.Entity($"{nameof(Employee)}{nameof(Project)}").HasData(employeeProjects);
        }
    }
}
