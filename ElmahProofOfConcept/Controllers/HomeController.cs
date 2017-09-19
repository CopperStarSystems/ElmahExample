//  --------------------------------------------------------------------------------------
// ElmahProofOfConcept.HomeController.cs
// 2017/09/19
//  --------------------------------------------------------------------------------------

using System;
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
            throw new Exception("Server Error.");
        }
    }
}