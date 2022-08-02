using EDU_Journal.Server.Services.PublicHolidayService;
using EDU_Journal.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EDU_Journal.Server.Controllers
{
    public class PublicHolidayController : Controller
    {
        private readonly IPublicHolidayService _publicHoliday;

        public PublicHolidayController(IPublicHolidayService publicHoliday)
        {
            _publicHoliday = publicHoliday;
        }

        [HttpPost]
        public IActionResult AddNewHoliday(PublicHolidayDto model)
        {
            _publicHoliday.AddHoliday(model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveHoliday(int id)
        {
            _publicHoliday.DeleteHoliday(id);
            return Ok();

        }
        [HttpGet]
        public ActionResult<List<PublicHolidayDto>> GelAllHolidays()
        {
            List<PublicHolidayDto> list = _publicHoliday.GetAllHolidays();
            return Ok(list);

        }

        [HttpGet("{id}")]
        public ActionResult<PublicHolidayDto> GetHolidayById(int id)
        {
            var data = _publicHoliday.GetHolidayById(id);
            return Ok(data);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHolidayById(int id)
        {
            _publicHoliday.UpdateHolidayById(id);
            return Ok();
        }
    }
}
