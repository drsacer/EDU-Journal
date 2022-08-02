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

        public WorkingDayController(IWorkingDayService workingDayService)
        {
            _workingDayService = workingDayService;    
        }

        [HttpPost]
        public IActionResult AddWorkingDay(WorkingDayDto model) 
        {
            _workingDayService.AddWorkingDay(model);

            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<WorkingDayDto> GetById(int id)
        {
            var data = _workingDayService.GetWorkingDayById(id);
            
            return Ok(data);
        }

        [HttpGet]
        public ActionResult<List<WorkingDayDto>> GetAllWorkingDays()
        {
            //metoda List<WorkingDayDto> GetAll() u WorkingDayService vraća listu WorkingDayDto
            var list = _workingDayService.GetAll(); 

            return Ok(list);
        }

        [HttpPut]
        public IActionResult UpdateWorkingDay(int id)
        {
            _workingDayService.UpdateWorkingDay(id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWorkingDay(int id)
        {
            _workingDayService.DeleteWorkingDay(id);
            return Ok();
        }
    }
}
