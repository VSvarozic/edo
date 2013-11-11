using EDO.Model.Common.Abstract;
using EDO.UI.WebUI.Models.JSON.Core;
using EDO.UI.WebUI.Utils;
using SimpleMembershipModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EDO.UI.WebUI.Controllers.Api
{
    [ApiRoledAuthorize]
    public class UserInfoController : ApiController
    {
        private IUserProfilesRepository _usersRepository;

        public UserInfoController(IUserProfilesRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        // Возвращаем краткую информацию о текущем пользователе
        public object Get()
        {
            var principal = ControllerContext.RequestContext.Principal;
            var id = MembershipUtils.GetUserIdByName(principal.Identity.Name);

            return new  {
                Data = new UserInfo(_usersRepository.GetProfileById(id)),
                Success = true
            };
        }
    }
}
