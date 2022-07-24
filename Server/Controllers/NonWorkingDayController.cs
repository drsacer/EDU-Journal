using EDU_Journal.Server.Services.NonWorkingDayService;
using EDU_Journal.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;


namespace EDU_Journal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NonWorkingDayController : ControllerBase
    {

        private readonly INonWorkingDayService _nonWorkingDayService;

       // [HttpPost]
        public IActionResult Book(NonWorkingDayDto model)
        {
            _nonWorkingDayService.Book(model);

            return Ok();
        }
    }
}
