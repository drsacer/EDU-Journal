using AutoMapper;
using EDU_Journal.Server.Data;
using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.VacationService
{
    public class VacationService : IVacationService
    {
        private readonly JournalDbContext _context;
        private readonly IMapper _mapper;

        public VacationService(JournalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

    

       public void CreateVacation(VacationDto model)
        {
            try
            { 
            /*
                var vacation = new Vacation()
                {
                    StartDate = dateFrom,
                    EndDate = dateTo,
                    Note = note
                };*/

                CalculateNumberOfVacationDays(model);
               
                var vacation = _mapper.Map<Vacation>(model);

                _context.Vacations.Add(vacation);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CreateVacation(DateOnly dateFrom, DateOnly dateTo, string? note)
        {
            throw new NotImplementedException();
        }

        private void CalculateNumberOfVacationDays(VacationDto vacation) {

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
