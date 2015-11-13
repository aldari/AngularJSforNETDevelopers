using System.Web.Mvc;
using AngularJSforNETDevelopers.Models.Registration;

namespace AngularJSforNETDevelopers.Controllers
{
    public class InstructorsController : JsonController
    {
        private readonly RegistarationVmBuilder _registarationVmBuilder = new RegistarationVmBuilder();

        public ActionResult Index()
        {
            return Json(_registarationVmBuilder.GetInstructorVms(), JsonRequestBehavior.AllowGet);
        }
    }
}