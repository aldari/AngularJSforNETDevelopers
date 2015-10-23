using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularJSforNETDevelopers.Controllers
{
    public class CourcesController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "", GetSerializeCourseVms());
        }

        public string GetSerializeCourseVms()
        {
            var courses = new[]
            {
                new CourseVm { Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                new CourseVm { Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                new CourseVm { Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"}
            };
            var settings = new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()};
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }
    }

    public class CourseVm
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
    }
}