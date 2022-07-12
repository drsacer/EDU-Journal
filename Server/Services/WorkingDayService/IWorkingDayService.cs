using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.WorkingDayService
{
    public interface IWorkingDayService
    {
        void Book(WorkingDayDto workingDay);
    }
}
