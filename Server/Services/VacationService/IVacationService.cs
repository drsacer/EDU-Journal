namespace EDU_Journal.Server.Services.VacationService
{
    public interface IVacationService
    {
        void Create(DateOnly dateFrom, DateOnly dateTo, string? note);
    }
}
