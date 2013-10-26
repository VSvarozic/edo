using System.Data.Entity;
using EDO.Model.Common.Entities;

namespace EDO.Data.EFModelCommon
{
    public class EFDBContext : DbContext
    {
        public EFDBContext() : base("DefaultConnection") { }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
