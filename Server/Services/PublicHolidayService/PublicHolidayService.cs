using AutoMapper;
using EDU_Journal.Server.Data;
using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EDU_Journal.Server.Services.PublicHolidayService
{
    public class PublicHolidayService:IPublicHolidayService
    {
        private readonly JournalDbContext _context;
        private readonly IMapper _mapper;

        public PublicHolidayService(JournalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddHoliday(PublicHolidayDto model)
        {
            var data = _mapper.Map<PublicHoliday>(model);  

            _context.Add(data);
            _context.SaveChanges();
        }

        public void DeleteHoliday(int id)
        {
            var data = _context.PublicHolidays.Find(id);
          
            _context.Remove(data);
            _context.SaveChanges();
        }

        public List<PublicHolidayDto> GetAllHolidays()
        {
            var data = _context.PublicHolidays.ToList();
            return _mapper.Map<List<PublicHolidayDto>>(data);
        }

        public PublicHolidayDto GetHolidayById(int id)
        {
            var data = _context.PublicHolidays.Find(id);
            return _mapper.Map<PublicHolidayDto>(data);
        }

        public void UpdateHolidayById(int id)
        {
            var data = _context.PublicHolidays.Find(id);

            _context.Entry(data).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
