using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.NonWorkingDayService
{
    public interface INonWorkingDayService
    {
        void Book(NonWorkingDayDto workingDay);
    }
}
