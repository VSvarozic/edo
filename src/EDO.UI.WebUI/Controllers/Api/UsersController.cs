﻿using EDO.Model.Common.Abstract;
using EDO.Model.Common.Entities;
using EDO.UI.WebUI.Models.JSON.Core;
using EDO.UI.WebUI.Utils;
using SimpleMembershipModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebMatrix.WebData;

namespace EDO.UI.WebUI.Controllers.Api
{
    [ApiRoledAuthorize]
    public class UsersController : ApiController
    {
        private IUserProfilesRepository _usersRepository;

        public UsersController(IUserProfilesRepository userRepository)
        {
            _usersRepository = userRepository;
        }

        // Получаем всех пользователей /api/users
        [ApiRoledAuthorize(Roles="Administrator")]
        public string Get()
        {
            return "";
        }

        // Получаем конкретного пользователя /api/users/123
        public UserProfile Get(int id)
        {
            return _usersRepository.GetProfileById(id);
        }
    }
}