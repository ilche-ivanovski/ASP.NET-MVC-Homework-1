using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1.Controllers
{
    public class AboutController : IController
    {
        // GET: About
        //It accepts object of RequestContext class,
        //which encapsulates information about an HTTP request that matches a defined route,
        //using the HttpContext and RouteData properties.
        public void Execute(RequestContext requestContext)
        {
            string html = string.Empty;

            html += "<html>{0}</html>";
            requestContext.HttpContext.Response.Write("Hello Ilche Ivanovski");
        }
    }
}