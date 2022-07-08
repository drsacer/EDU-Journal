using EDU_Journal.Server.Entities;

namespace EDU_Journal.Server.Services.VacationService
{
    public class VacationService
    {
        private readonly Vacation _vacation;

        public VacationService(Vacation vacation)
        {
            _vacation = vacation;
        }

        public byte numberOfVacationDays() {

           // int vacationDays = 0;
            _vacation.TotalDays = 0;

            if (_vacation.EndDate < _vacation.StartDate)
            {
                throw new ArgumentException("Incorrect date");
            } 
            else
            {
                for (var date = _vacation.StartDate; date < _vacation.EndDate; date.AddDays(1))
                {
                    if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                    {
                        _vacation.TotalDays++;
                    }
                }
                //vacationDays = _vacation.EndDate.DayNumber - _vacation.StartDate.DayNumber;
            }
            
            return _vacation.TotalDays;
        
        }
    }
}
