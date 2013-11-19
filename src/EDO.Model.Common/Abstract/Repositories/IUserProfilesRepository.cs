using EDO.Model.Common.Entities;

namespace EDO.Model.Common.Abstract.Repositories
{
    public interface IUserProfilesRepository
    {
        UserProfile GetProfileById(int id);

    }
}