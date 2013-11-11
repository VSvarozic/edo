using System.Data.Entity;
using EDO.Model.Common.Entities;

namespace EDO.Data.EFModelCommon
{
    public class EFDBContext : DbContext
    {
        public EFDBContext() : base("DefaultConnection") { }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<UserPosition> UserPositions { get; set; }
    }
}
