using System.ComponentModel.DataAnnotations.Schema;

namespace EDO.Model.Common.Entities
{
    [Table("UserProfile")]
    public class UserProfile : Entity
    {
        public string UserName { get; set; }
    }
}
