namespace EDU_Journal.Server.Entities
{
    public class Vacation
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public byte TotalDays { get; set; }
        public string? Note { get; set; }

    }
}
