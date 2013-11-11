using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDO.Model.Common.Entities
{
    [Table("UserProfile")]
    public class UserProfile : Entity
    {
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }

        public virtual Business Business { get; set; }
        public virtual Office Office { get; set; }
        public virtual List<UserPosition> Positions { get; set; }
    }
}
