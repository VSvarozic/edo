using SimpleMembershipModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Hosting;
using System.Xml.Linq;
using EDO.UI.WebUI.Models;

namespace EDO.UI.WebUI.Controllers.Api
{

    [ApiRoledAuthorize]
    public class SiteMenuController : ApiController
    {
        public Menu Get()
        {
            var principal = ControllerContext.RequestContext.Principal;
            var path = HostingEnvironment.MapPath("~/App_Data/SiteMenu.xml");
            var parser = new MenuParser(principal);
            var menu = parser.LoadFromXMLFile(path);

            return menu;
        }
    }
}
