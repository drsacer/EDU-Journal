using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.WorkingDayService
{
    public interface IWorkingDayService
    {
        public void AddWorkingDay(WorkingDayDto workingDay);
        public WorkingDayDto GetWorkingDayById(int id);
        public List<WorkingDayDto> GetAll(); 
        public void UpdateWorkingDay(int id);
        public void DeleteWorkingDay(int id);
    }
}
