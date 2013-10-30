using SimpleMembershipModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Hosting;
using System.Xml.Linq;

namespace EDO.UI.WebUI.Controllers.Api
{

    [ApiRoledAuthorize]
    public class SiteMenuController : ApiController
    {
        public List<object> Get()
        {
            List<object> result = new List<object>();

            var path = HostingEnvironment.MapPath("~/App_Data/SiteMenu.xml");
            var document = XDocument.Load(path);
            var menuItems = document.Element("menu").Element("items").Elements("item");

            var principal = ControllerContext.RequestContext.Principal;

            foreach (var item in menuItems)
            {
                object newItem = null;

                var roles = item.Element("roles").Elements("role");

                //if(roles.Count() == 0 || !roles.Any(p => principal.IsInRole(p.ToString())))
                //{
                //    continue;
                //}

                var text = item.Element("text").ToString();

                var subMenu = item.Element("items");

                if(subMenu == null)
                {
                    newItem = new
                    {
                        Text = text,
                        Controller = item.Element("controller").ToString(),
                        Action = item.Element("action").ToString(),
                        Target = item.Element("target").ToString()
                    };
                }
                else
                {
                    newItem = new
                    {
                        Text = text,
                        Items = new object()
                    };
                }

                if (newItem != null)
                {
                    result.Add(newItem);
                }
            }

            return result;
        }
    }
}
