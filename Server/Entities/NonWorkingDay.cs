namespace EDU_Journal.Server.Entities
{
    public class NonWorkingDay
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public User User { get; set; }
        public string? Note { get; set; }
        public SickLeave SickLeave { get; set; }

    }
}
