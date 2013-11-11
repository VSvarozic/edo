using EDO.Model.Common.Abstract;
using EDO.Model.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EDO.UI.WebUI.Models.JSON.Core
{

    [DataContract(Name = "UserInfo", Namespace = "")]
    public class UserInfo
    {
        private UserProfile _profile;

        [DataMember(EmitDefaultValue = false)]
        public int UserId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string BusinessName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string OfficeName { get; set; }

        public UserInfo(UserProfile profile)
        {
            _profile = profile;

            UserId = _profile.Id;
            Name = _profile.UserName;

            if (_profile.Business != null)
            {
                BusinessName = _profile.Business.Title;
            }

            if (_profile.Office != null)
            {
                OfficeName = _profile.Office.Title;
            }
        }
    }
}