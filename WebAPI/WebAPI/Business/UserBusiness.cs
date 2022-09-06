using WebAPI.Business.Interface;
using WebAPI.Models;
using WebAPI.Utilities.Interface;

namespace WebAPI.Business
{
    public class UserBusiness : IUserBusiness
    {
        private IUtilities utilities;
        public UserBusiness(IUtilities _utilities)
        {
            utilities = _utilities;
        }

        public bool SaveUserDetails(IEnumerable<User> users, string filePath)
        {
            try
            {
                var user = new User();
                users.ToList().ForEach(usr =>
                {
                    user.FirstName = usr.FirstName;
                    user.LastName = usr.LastName;
                });

                return utilities.Write(users, filePath);
            }
            catch { return false; }
        }
    }
}
