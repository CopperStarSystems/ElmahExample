//  --------------------------------------------------------------------------------------
// ElmahProofOfConcept.Class1.cs
// 2017/09/19
//  --------------------------------------------------------------------------------------

using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ElmahProofOfConcept.Controllers;

namespace ElmahProofOfConcept
{
    public class MvcApplication : HttpApplication
    {
        // Handle exceptions that occur outside the MVC layer
        protected void Application_Error(object sender, EventArgs args)
        {
            var ex = Server.GetLastError();
            if (ex is HttpException)
                // We're already handling these with handlers
                // in httpErrors
                return;

            var httpContext = ((MvcApplication)sender).Context;
            var currentController = " ";
            var currentAction = " ";
            var currentRouteData =
                RouteTable.Routes.GetRouteData(new HttpContextWrapper(httpContext));

            if (currentRouteData != null)
            {
                if (currentRouteData.Values["controller"] != null &&
                    !string.IsNullOrEmpty(currentRouteData.Values["controller"].ToString()))
                    currentController = currentRouteData.Values["controller"].ToString();

                if (currentRouteData.Values["action"] != null &&
                    !string.IsNullOrEmpty(currentRouteData.Values["action"].ToString()))
                    currentAction = currentRouteData.Values["action"].ToString();
            }
            
            var controller = new ErrorHandlerController();
            var routeData = new RouteData();

            httpContext.ClearError();
            httpContext.Response.Clear();

            // Don't do this in production, it's like this for
            // demonstration purposes.  Uncomment this to see how it would
            // actually behave in production.
            //httpContext.Response.StatusCode = ex is HttpException
            //    ? ((HttpException)ex).GetHttpCode()
            //    : 500;
            httpContext.Response.TrySkipIisCustomErrors = true;

            routeData.Values["controller"] = "ErrorHandler";

            var action = "ApplicationError";
            routeData.Values["action"] = action;
            // Set the Controller's model
            controller.ViewData.Model =
                new HandleErrorInfo(ex, currentController, currentAction);
            ((IController)controller).Execute(
                new RequestContext(new HttpContextWrapper(httpContext), routeData));
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}