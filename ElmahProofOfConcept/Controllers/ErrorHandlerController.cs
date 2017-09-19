//  --------------------------------------------------------------------------------------
// ElmahProofOfConcept.ErrorHandlerController.cs
// 2017/09/19
//  --------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Web.Mvc;

namespace ElmahProofOfConcept.Controllers
{
    public class ErrorHandlerController : Controller
    {
        // GET: ErrorHandler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            ViewData.Add(new KeyValuePair<string, object>("NotFoundUrl", HttpContext.Request.RawUrl));

            return View();
        }

        public ActionResult Unauthorized()
        {
            return View();
        }

        public ActionResult ServerError()
        {
            return View();
        }

        public ActionResult ApplicationError()
        {
            return View();
        }
    }
}