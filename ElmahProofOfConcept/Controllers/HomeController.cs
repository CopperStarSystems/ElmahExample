//  --------------------------------------------------------------------------------------
// ElmahProofOfConcept.HomeController.cs
// 2017/09/19
//  --------------------------------------------------------------------------------------

using System;
using System.Web;
using System.Web.Mvc;

namespace ElmahProofOfConcept.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ServerError()
        {
            throw new HttpException(500, "Simulated MVC 500 Error");
        }

        public ActionResult Unauthorized()
        {
            return new HttpUnauthorizedResult();
        }

        public ActionResult NonHttpError()
        {
            throw new Exception("Non-Http Error thrown in Controller");
        }

        public ActionResult ViewError()
        {
            return View();
        }
    }
}