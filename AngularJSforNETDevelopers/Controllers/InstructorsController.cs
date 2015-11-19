using System.Web.Http;
using AngularJSforNETDevelopers.Models.Instructors;
using AngularJSforNETDevelopers.Models.Registration;

namespace AngularJSforNETDevelopers.Controllers
{
    public class InstructorsController : ApiController
    {
        private readonly RegistarationVmBuilder _registarationVmBuilder = new RegistarationVmBuilder();

        public InstructorVm[] Get()
        {
            return _registarationVmBuilder.GetInstructorVms();
        }
    }
}