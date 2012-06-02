using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Azure.ACS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var identity = HttpContext.User.Identity as Microsoft.IdentityModel.Claims.IClaimsIdentity;

            ViewBag.NameIdentifier = "";
            if (identity != null)
            {
                ViewBag.NameIdentifier = identity.Claims.First(x => x.ClaimType.Contains("nameidentifier")).Value;
            }

            return View();
        }
    }
}
