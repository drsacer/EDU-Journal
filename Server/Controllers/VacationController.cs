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

        
        [HttpPost]
        public IActionResult CreateVacation(VacationDto vacation)
        {
            _vacationService.CreateVacation(vacation);
            return Ok();
        }

        [HttpGet]
        public ActionResult<VacationDto> GetVacation(int id)
        {
            var vacation = _vacationService.GetVacationById(id);
            return Ok(vacation);
        }

        [HttpGet("{id}")]
        public ActionResult<List<VacationDto>> GetAllVacations()
        {
            var vacation = _vacationService.GetAllVacations();
            return Ok(vacation);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVacation(int id)
        {
            _vacationService.UpdateVacation(id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVacation(int id)
        {
            _vacationService.DeleteVacation(id);
            return Ok();
        }
    }
}
