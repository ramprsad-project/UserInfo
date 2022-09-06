using Microsoft.AspNetCore.Mvc;
using WebAPI.Business.Interface;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserAcountController : ControllerBase
    {

        private readonly ILogger<UserAcountController> _logger;
        private readonly IUserBusiness _userBusiness;
        public UserAcountController(ILogger<UserAcountController> logger, IUserBusiness userBusiness)
        {
            _logger = logger;
            _userBusiness = userBusiness;
        }
       
        [HttpPost("insert")]
        public bool UpdateUserDetails([FromBody] IEnumerable<User> users,string filePath)
        {
            return _userBusiness.SaveUserDetails(users, filePath);
        }
    }
}