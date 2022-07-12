using AutoMapper;
using EDU_Journal.Server.Data;
using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.WorkingDayService
{
    public class WorkingDayService : IWorkingDayService
    {
        private readonly JournalDbContext _context;
        private readonly IMapper _mapper;

        public WorkingDayService(JournalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Book(WorkingDayDto workingDay)
        {
            var data = _mapper.Map<WorkingDay>(workingDay);

            _context.WorkingDays.Add(data);

            _context.SaveChanges();
        }

        public WorkingDayDto Get(int id)
        {
            var data = _context.WorkingDays.FirstOrDefault(x => x.Id == id);    

            return _mapper.Map<WorkingDayDto>(data);
        }
    }
}
