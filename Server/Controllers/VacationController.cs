using EDU_Journal.Server.Services.VacationService;
using EDU_Journal.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EDU_Journal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacationController : Controller
    {
        private readonly IVacationService _vacationService;

        public VacationController(IVacationService vacationService)
        {
            _vacationService = vacationService;
        }

        /*
        [HttpPost]
        public IActionResult CreateVacation (DateOnly startDate, DateOnly endDate, String note) //VacationDto vacation - kao i WorkingDay
        {
            _vacationService.CreateVacation(startDate, endDate, note);

            return Ok();
        } */

        [HttpPost]
        public IActionResult CreateVacation(VacationDto vacation) //VacationDto vacation - kao i WorkingDay
        {
            _vacationService.CreateVacation(vacation);

            return Ok();
        }
    }
}
