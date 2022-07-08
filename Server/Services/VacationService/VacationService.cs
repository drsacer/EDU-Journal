using EDU_Journal.Server.Data;
using EDU_Journal.Server.Entities;

namespace EDU_Journal.Server.Services.VacationService
{
    public class VacationService : IVacationService
    {
        private readonly JournalDbContext _context;

        public VacationService(JournalDbContext context)
        {
            _context = context; 
        }

        public void Create(DateOnly dateFrom, DateOnly dateTo, string? note)
        {
            try
            {
                var vacation = new Vacation()
                {
                    StartDate = dateFrom,
                    EndDate = dateTo,
                    Note = note
                };

                CalculateNumberOfVacationDays(vacation);

                _context.Vacations.Add(vacation);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CalculateNumberOfVacationDays(Vacation vacation) {

            // int vacationDays = 0;
            vacation.TotalDays = 0;

            if (vacation.EndDate < vacation.StartDate)
            {
                throw new ArgumentException("Incorrect date");
            } 
            else
            {
                for (var date = vacation.StartDate; date < vacation.EndDate; date.AddDays(1))
                {
                    if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                    {
                        vacation.TotalDays++;
                    }
                }
                //vacationDays = _vacation.EndDate.DayNumber - _vacation.StartDate.DayNumber;
            }
        }
    }
}
