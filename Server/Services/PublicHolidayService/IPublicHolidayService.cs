using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.PublicHolidayService
{
    public interface IPublicHolidayService
    {
        public void AddHoliday(PublicHolidayDto publicHoliday);
        public List<PublicHolidayDto> GetAllHolidays();
        public PublicHolidayDto GetHolidayById(int id);
        public void UpdateHolidayById(int id);
        public void DeleteHoliday(int id);
    }
}
