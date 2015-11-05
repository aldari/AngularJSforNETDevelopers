using System.Web.Mvc;
using AngularJSforNETDevelopers.Models.Registration;

namespace AngularJSforNETDevelopers.Controllers
{
    public class CourcesController : Controller
    { 
        private readonly RegistarationVmBuilder _registarationVmBuilder = new RegistarationVmBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _registarationVmBuilder.GetSerializeCourses());
        }
    }
}