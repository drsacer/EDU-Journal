using EDU_Journal.Server.Data;
using EDU_Journal.Server.Entities;

namespace EDU_Journal.Server.Services.WorkingDayService
{
    public class WorkingDayService : IWorkingDayService
    {
        private readonly JournalDbContext _context;
        private readonly WorkingDay _workingDay;
        // je li ovo isto kao i da u parametrima fukncije MonthlyNumbersOfWorkingHours dodam (WorkingDay workingDay) ?

        
        private List<String> months = new List<string>(new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September" });

        public WorkingDayService (JournalDbContext context, WorkingDay workingDay)
        {
            _context = context;
            _workingDay = workingDay;
        }

        // Kako pozvati tu funkciju i probati unijeti podatke početnog i završnog vremena u konzoli
        public TimeSpan MonthlyNumbersOfWorkingHours(WorkingDay workingday)
        {
           int NumberOfDays = 0;
           TimeSpan DailyNumberOfWorkingHours = _workingDay.EndTime - _workingDay.StartTime ; // - _workingDay.PauseDuration
           NumberOfDays++;

           // Console.Write(number);
            return DailyNumberOfWorkingHours * NumberOfDays ;
        }

        // napraviti listu mjeseca i upisivati ukupan broj sati pojedinog mjeseca - vratiti broj sati
    }
}
