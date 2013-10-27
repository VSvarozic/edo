using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMembershipModule;

namespace EDO.UI.WebUI.Controllers
{
    [RoledAuthorize]
    public class TestAuthController : Controller
    {
        //
        // GET: /TestAuth/
        public ActionResult Index()
        {
            return View();
        }
	}
}