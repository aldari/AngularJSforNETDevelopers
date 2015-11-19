using AngularJSforNETDevelopers.Models.Courses;
using AngularJSforNETDevelopers.Models.Registration;
using System.Web.Http;

namespace AngularJSforNETDevelopers.Controllers
{
    public class CoursesController : ApiController
    {
        private readonly RegistarationVmBuilder _registarationVmBuilder = new RegistarationVmBuilder();
        
        public CourseVm[] Get()
        {
            return _registarationVmBuilder.GetCourseVms();
        }
    }
}