using WebAPI.Models;

namespace WebAPI.Business.Interface
{
    public interface IUserBusiness
    {
        bool SaveUserDetails(IEnumerable<User> users, string filePath);
    }
}
