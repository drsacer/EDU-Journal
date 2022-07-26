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

        /*
        [HttpGet]
        [Route("saveUsers")]
        public IActionResult Save()
        {
            _userService.AddUser(new UserDto());
            return Ok();
        }
        */

        [HttpGet]
        public ActionResult<List<UserDto>> GetAll()
        {
            var data = _userService.GetAllUsers();
            return Ok(data);
        }


        [HttpPost]
        public IActionResult AddNewUser(UserDto newUser)
        {
            _userService.AddUser(newUser);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser(UserDto user)
        {
            _userService.UpdateUser(user); 
            return Ok();
        }

        [HttpGet("{id}")]
        public  IActionResult GetUserData(int id)
        {
            //U UserService metoda GetUserData vraća UserDto pa je tip podataka u liniji ispod UserDto
            UserDto user = _userService.GetUserData(id);
            return Ok(user);
        }

        [HttpDelete("{id")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }
    }
}
