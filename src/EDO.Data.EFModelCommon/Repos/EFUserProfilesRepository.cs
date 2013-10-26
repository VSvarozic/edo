using EDO.Model.Common.Abstract;

namespace EDO.Data.EFModelCommon.Repos
{
    public class EFUserProfilesRepository : IUserProfilesRepository
    {
        public int Id { get; set; }

        public EFUserProfilesRepository()
        {
            Id = 200;
        }
    }
}
