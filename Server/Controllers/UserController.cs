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

        [HttpGet]
        [Route("saveUsers")]
        public IActionResult Save()
        {
            _userService.AddUser(new UserDto());
            return Ok();
        }

        [HttpPost]
        public IActionResult Add (UserDto newUser)
        {
            _userService.AddUser (newUser);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<UserDto>> GetAll() {

            _userService.GetAllUsers();
            return Ok();
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
        }*/



    }
}
