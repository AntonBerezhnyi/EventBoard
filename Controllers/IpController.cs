using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;

namespace EventBoard.Controllers
{
    public class IpController : IController
    {
        public void Execute (RequestContext requestContext)
        {
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            var response = requestContext.HttpContext.Response;
            response.Write("<h2>Your Ip-adress: " + ip + "</h2");
        }
    }
}