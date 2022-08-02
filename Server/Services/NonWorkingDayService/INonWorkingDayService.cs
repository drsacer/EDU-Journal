using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.NonWorkingDayService
{
    public interface INonWorkingDayService
    {
        public void AddNewNonWorkingDay(NonWorkingDayDto workingDay);
        public NonWorkingDayDto GetNonWorkingDayById(int id);
        public List<NonWorkingDayDto> GetAllNonWorkingDays();
        public void UpdateNonWorkingDayById(int id);
        public void DeleteNonWorkingDayById(int id);
    }
}
