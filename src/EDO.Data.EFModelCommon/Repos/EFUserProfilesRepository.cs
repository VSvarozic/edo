using EDO.Model.Common.Abstract;
using EDO.Model.Common.Entities;
using System.Linq;

namespace EDO.Data.EFModelCommon.Repos
{
    public class EFUserProfilesRepository : IUserProfilesRepository
    {
        private EFDBContext _context;

        public EFUserProfilesRepository()
        {
            _context = new EFDBContext();
        }

        public UserProfile GetProfileById(int id)
        {
            return _context.UserProfiles.FirstOrDefault(up => up.Id == id);
        }
    }
}
