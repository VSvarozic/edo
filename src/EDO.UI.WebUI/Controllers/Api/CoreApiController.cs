using EDO.Model.Common.Abstract;
using EDO.UI.WebUI.Models;
using EDO.UI.WebUI.Models.JSON.Core;
using EDO.UI.WebUI.Utils;
using SimpleMembershipModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace EDO.UI.WebUI.Controllers.Api
{
    [ApiRoledAuthorize]
    public class CoreApiController : ApiController
    {
        private IUserProfilesRepository _usersRepository;

        public CoreApiController(IUserProfilesRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public object Get()
        {
            var principal = ControllerContext.RequestContext.Principal;
            

            var coreApi = new CoreApi();

            var userId = MembershipUtils.GetUserIdByName(principal.Identity.Name);
            var currUser = _usersRepository.GetProfileById(userId);
            coreApi.UserInfo = new UserInfo(currUser);


            return new
            {
                Data = coreApi,
                Success = true
            };
        }
    }
}
