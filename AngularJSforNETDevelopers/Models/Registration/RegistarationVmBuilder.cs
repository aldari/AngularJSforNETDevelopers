using AngularJSforNETDevelopers.Models.Courses;
using AngularJSforNETDevelopers.Models.Instructors;

namespace AngularJSforNETDevelopers.Models.Registration
{
    public class RegistarationVmBuilder
    {
        public CourseVm[] GetCourseVms()
        {
            var courses = new[]
            {
                new CourseVm { Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                new CourseVm { Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                new CourseVm { Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"}
            };
            return courses;
        }

        public InstructorVm[] GetInstructorVms()
        {
            var instructors = new[]
             {
                new InstructorVm { Name = "Rubeus Hagrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001 },
                new InstructorVm { Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105 },
                new InstructorVm { Name = "Minerva McGonagall", Email = "Transfiguration", RoomNumber = 102 }
            };
            return instructors;
        }
    }
}