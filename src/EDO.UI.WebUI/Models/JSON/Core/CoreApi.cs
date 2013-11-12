using EDO.Model.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Web;

namespace EDO.UI.WebUI.Models.JSON.Core
{
    [DataContract(Name = "CoreApi", Namespace = "")]
    public class CoreApi
    {
        [DataMember]
        public UserInfo UserInfo { get; set; }
    }


}