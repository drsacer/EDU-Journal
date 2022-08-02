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


        [HttpPost]
        public IActionResult AddNewUser(UserDto newUser)
        {
            _userService.AddUser(newUser);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<UserDto>> GetAll()
        {
            var data = _userService.GetAllUsers();
            return Ok(data);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id)
        {
            _userService.UpdateUserById(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUserData(int id)
        {
            //U UserService metoda GetUserDataById vraća UserDto pa je tip podataka u liniji ispod UserDto (može biti var user)
            UserDto user = _userService.GetUserDataById(id);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUserById(id);
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult ChangePassword(int id, string password)
        {
            _userService.ChangePassword(id, password);
            return Ok();
        }
    }
}
