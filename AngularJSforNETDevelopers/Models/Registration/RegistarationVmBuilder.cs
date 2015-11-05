using AngularJSforNETDevelopers.Models.Courses;
using AngularJSforNETDevelopers.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularJSforNETDevelopers.Models.Registration
{
    public class RegistarationVmBuilder
    {
        public RegistrationVm BuildRegistrationVm()
        {
            var registrationVm = new RegistrationVm
            {
                Courses = GetSerializeCourses(),
                Instructors = GetSerializeInstructors()
            };
            return registrationVm;
        }

        public string GetSerializeCourses()
        {
            var courses = new[]
            {
                new CourseVm { Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                new CourseVm { Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                new CourseVm { Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }


        public string GetSerializeInstructors()
        {
            var courses = new[]
             {
                new InstructorVm { Name = "Rubeus Hagrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001 },
                new InstructorVm { Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105 },
                new InstructorVm { Name = "Minerva McGonagall", Email = "Transfiguration", RoomNumber = 102 }
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }
    }
}