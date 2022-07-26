using AutoMapper;
using EDU_Journal.Server.Data;
using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

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

        public void AddWorkingDay(WorkingDayDto workingDay)  
        {
            var data = _mapper.Map<WorkingDay>(workingDay); 

            _context.WorkingDays.Add(data);
            _context.SaveChanges(); 
        }

        // ovu metodu poziva kontroler, preko contexta dohvaća se u bazu WorkingDays i vraća se 1 radni dani klijentu
        public WorkingDayDto GetWorkingDay(int id) 
        {
            var data = _context.WorkingDays.FirstOrDefault(x => x.Id == id);    

            return _mapper.Map<WorkingDayDto>(data);
        }

        // ovu metodu poziva kontroler, preko contexta dohvaća se u bazu WorkingDays i vraćaju se SVI radni dani klijentu u obliku liste
        public List<WorkingDayDto> GetAll()
        {
            var data = _context.WorkingDays.ToList();

            return _mapper.Map<List<WorkingDayDto>>(data);
        }

        public void UpdateWorkingDay(WorkingDayDto workingDay)
        {
            _context.Entry(workingDay).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteWorkingDay(int id)
        {
            var data = _context.WorkingDays.Find(id);
            
            _context.Remove(data);
            _context.SaveChanges();
        }

        private int Calculate()
        {
            return 1;
        }

    }
}
