using EDU_Journal.Server.Services.WorkingDayService;
using EDU_Journal.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EDU_Journal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkingDayController : ControllerBase
    {
        private readonly IWorkingDayService _workingDayService;

        public WorkingDayController(IWorkingDayService _workingDayService)
        {
            _workingDayService = _workingDayService;    
        }

        [HttpPost]
        // od kuda taj model koji se šalje preko interfejsa do WorkingDayService? To je ono što klijent upiše na browseru?
        public IActionResult BookWD(WorkingDayDto model) 
        {
            _workingDayService.Book(model);

            return Ok();
        }

        // poziva se metoda GetAll u interfejsu kojeg implamentira WorkingDayService
        [HttpGet]
        public ActionResult<List<WorkingDayDto>> GetAllWD()
        {
            return Ok(_workingDayService.GetAll());
        }

        [HttpGet]
        public ActionResult<List<WorkingDayDto>> GetById(int id)
        {
            return Ok(_workingDayService.GetById(id));
        }
    }
}
