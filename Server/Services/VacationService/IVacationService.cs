using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.VacationService
{
    public interface IVacationService
    {
       void CreateVacation (DateOnly dateFrom, DateOnly dateTo, string? note);

        // void CreateVacation(VacationDto vacation);
    }
}
