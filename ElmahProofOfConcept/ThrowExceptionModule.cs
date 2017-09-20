using System;
using System.Web;

namespace ElmahProofOfConcept
{
    public class ThrowExceptionModule : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            context.LogRequest += new EventHandler(OnLogRequest);
            context.BeginRequest += HandleRequest;
        }

        void HandleRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication) sender;
            HttpRequest x;
            if(application.Request.RawUrl == "/Home/ModuleError")
                throw new Exception();
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
}
