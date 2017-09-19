﻿//  --------------------------------------------------------------------------------------
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

        public ActionResult NotFound(string aspxerrorpath)
        {
            ViewData.Add(new KeyValuePair<string, object>("NotFoundUrl", aspxerrorpath));

            return View();
        }

        public ActionResult ServerError()
        {
            return View();
        }
    }
}