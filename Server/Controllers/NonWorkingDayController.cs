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

        [HttpPost]
        public IActionResult CreateNonWorkingDay(NonWorkingDayDto nonWorkingDay)
        {
            _nonWorkingDayService.AddNewNonWorkingDay(nonWorkingDay);
            return Ok();
        }


        [HttpGet("{id}")]
        public ActionResult<NonWorkingDayDto> GetNonWorkingDay(int id)
        {
            var nonWorkingDay = _nonWorkingDayService.GetNonWorkingDayById(id);
            return Ok(nonWorkingDay);
        }

        [HttpGet]
        public ActionResult<List<NonWorkingDayDto>> GetAllNonWorkingDays()
        {
            var nonWorkingDay = _nonWorkingDayService.GetAllNonWorkingDays();
            return Ok(nonWorkingDay);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateNonWorkingDay(int id)
        {
            _nonWorkingDayService.UpdateNonWorkingDayById(id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNonWorkingDay(int id)
        {
            _nonWorkingDayService.DeleteNonWorkingDayById(id);
            return Ok();
        }
    }
}
