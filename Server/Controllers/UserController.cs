using EDU_Journal.Server.Services;
using Microsoft.AspNetCore.Mvc;
using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly ILogger<UserController> _logger;


        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        /* proba K

        [HttpGet]
        public IActionResult GetUsers()
        {


            var users = _userService.GetAll();

            var memUsers = new LinkedList<UserDto>();
            memUsers.AddLast(new UserDto());
            memUsers.AddLast(new UserDto());
            memUsers.AddLast(new UserDto());


            return Ok(memUsers);
        }

        [HttpGet]
        [Route("saveUsers")]
        public IActionResult saveTestUsers()
        {
            _userService.AddUser(new UserDto());
            return Ok();
        }
        */
    }
}
