using EDO.Model.Common.Entities;
namespace EDO.Model.Common.Abstract
{
    public interface IUserProfilesRepository
    {
        UserProfile GetProfileById(int id);

    }
}