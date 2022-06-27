using EDU_Journal.Server.Entities;

namespace EDU_Journal.Server.Entities
{
    public class WorkingDay
    {

        public int Id { get; set; }
        public User User { get; set; }
        public DateOnly Date { get; set; }

        public TimeOnly?  StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }

        public TimeOnly? PauseDuration { get; set; }
    }
}
