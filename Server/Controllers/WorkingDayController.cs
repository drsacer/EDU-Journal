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
        public IActionResult Book(WorkingDayDto model)
        {
            _workingDayService.Book(model);

            return Ok();
        }
    }
}
