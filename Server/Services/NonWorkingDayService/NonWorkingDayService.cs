using EDU_Journal.Shared.DTOs;
using EDU_Journal.Server.Data;
using AutoMapper;
using EDU_Journal.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace EDU_Journal.Server.Services.NonWorkingDayService
{
    public class NonWorkingDayService : INonWorkingDayService
    {
        private readonly JournalDbContext _context;
        private readonly IMapper _mapper;

        public NonWorkingDayService(JournalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    
        public void AddNewNonWorkingDay(NonWorkingDayDto model)
        {
            var data = _mapper.Map<NonWorkingDay>(model);

            _context.NonWorkingDays.Add(data);
            _context.SaveChanges();
        }

        public NonWorkingDayDto GetNonWorkingDayById(int id)
        {
            var nonWorkingDay = _context.NonWorkingDays.Find(id);
            return _mapper.Map<NonWorkingDayDto>(nonWorkingDay);
        }
        public List<NonWorkingDayDto> GetAllNonWorkingDays()
        {
            var list = _context.NonWorkingDays.ToList();
            return _mapper.Map<List<NonWorkingDayDto>>(list);
        }

        public void DeleteNonWorkingDayById(int id)
        {
            var nonWorkingDay = _context.NonWorkingDays.Find(id);

            _context.Remove(nonWorkingDay);
            _context.SaveChanges();
        }

        public void UpdateNonWorkingDayById(int id)
        {
            var nonWorkingDay = _context.NonWorkingDays.Find(id);

            _context.Entry(nonWorkingDay).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
