using EDU_Journal.Shared.DTOs;
using EDU_Journal.Server.Data;
using AutoMapper;
using EDU_Journal.Server.Entities;

namespace EDU_Journal.Server.Services.NonWorkingDayService
{
    public class NonWorkingDayService : INonWorkingDayService
    {
        private readonly JournalDbContext _context;
        private readonly Mapper _mapper;
        public void Book(NonWorkingDayDto model)
        {
            var data = _mapper.Map<NonWorkingDay>(model);

            _context.NonWorkingDays.Add(data);
            _context.SaveChanges();

        }
    }
}
