using System.Web.Mvc;
using AngularJSforNETDevelopers.Models.Registration;

namespace AngularJSforNETDevelopers.Controllers
{
    public class CoursesController : JsonController
    {
        private readonly RegistarationVmBuilder _registarationVmBuilder = new RegistarationVmBuilder();
        
        public ActionResult Index()
        {
            return Json(_registarationVmBuilder.GetCourseVms(), JsonRequestBehavior.AllowGet);
        }
    }
}