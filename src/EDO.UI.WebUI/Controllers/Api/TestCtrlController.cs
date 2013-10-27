using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleMembershipModule;

namespace EDO.UI.WebUI.Controllers.Api
{
    [ApiRoledAuthorize]
    public class TestCtrlController : ApiController
    {
        public string Get()
        {
            return "Successfull";
        }

        [ApiRoledAuthorize(Roles = "NotExRole")]
        public string Get(int id)
        {
            return "Successfull " + id.ToString();
        }
    }
}
