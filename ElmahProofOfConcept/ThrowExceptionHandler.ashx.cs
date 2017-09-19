//  --------------------------------------------------------------------------------------
// ElmahProofOfConcept.ThrowExceptionHandler.ashx.cs
// 2017/09/19
//  --------------------------------------------------------------------------------------

using System;
using System.Web;

namespace ElmahProofOfConcept
{
    /// <summary>
    ///     Summary description for ThrowExceptionHandler
    /// </summary>
    public class ThrowExceptionHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            throw new Exception("Thrown from ThrowExceptionHandler");
        }
    }
}