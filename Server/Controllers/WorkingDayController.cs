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
        public IActionResult AddWorkingDay(WorkingDayDto model) 
        {
            _workingDayService.AddWorkingDay(model);

            return Ok();
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            WorkingDayDto workingDayDto = _workingDayService.GetWorkingDay(id);
            
            return Ok(workingDayDto);
        }

        [HttpGet]
        public ActionResult<List<WorkingDayDto>> GetAllWorkingDays()
        {
            //metoda List<WorkingDayDto> GetAll() u WorkingDayService vraća listu WorkingDayDto
            List<WorkingDayDto> list = _workingDayService.GetAll(); 

            return Ok(list);
        }

        [HttpPut]
        public IActionResult UpdateWorkingDay(WorkingDayDto workingDay)
        {
            _workingDayService.UpdateWorkingDay(workingDay);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteWorkingDay(int id)
        {
            _workingDayService.DeleteWorkingDay(id);
            return Ok();
        }
    }
}
