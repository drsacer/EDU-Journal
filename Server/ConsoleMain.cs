using EDU_Journal.Server.Entities;

namespace EDU_Journal.Server 
{
    public class ConsoleMain
    {
        public static void Main(string[] args)
        {
            User drago = new User();
            drago.Email = "drsacer@gmail.com";

            /*
            WorkingDay workingDay = new WorkingDay();
            workingDay.User = drago;
            workingDay.Date = new DateOnly(2022, 06, 21);
            var startTime =  workingDay.StartTime = new TimeOnly(8, 00);
            var endtime = workingDay.EndTime = new TimeOnly(16, 00);
            workingDay.PauseDuration = new TimeOnly (0,30);

            WorkingDay workingDay2 = new WorkingDay();
            workingDay2.User = drago;
            workingDay2.Date = new DateOnly(2022, 06, 22);
            workingDay2.StartTime = new TimeOnly(8, 00);
            workingDay2.EndTime = new TimeOnly(16, 00);

            WorkingDay workingDay3 = new WorkingDay();
            workingDay2.User = drago;
            workingDay2.Date = new DateOnly(2022, 06, 23);
            workingDay2.StartTime = new TimeOnly(8, 00);
            workingDay2.EndTime = new TimeOnly(16, 00);
            

            var workTime = endtime - startTime;
            Console.WriteLine(workTime.ToString()); 
            */


        }
    }
}
