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
            var data = _mapper.Map<WorkingDay>(workingDay); // tu se mapira iz WorkingDayDto u WorkingDay

            // da li se tu zapisuje u bazu? U bazi već imamo WorkingDay, što se dešava u bazi ako WorkingDayDTO nema iste fieldove kao i WorkingDay?
            _context.WorkingDays.Add(data);

            _context.SaveChanges(); // sprema se u bazu?
        }

        // ovu metodu poziva kontroler, preko contexta dohvaća se u bazu WorkingDays i vraća se 1 radni dani klijentu
        public WorkingDayDto GetById(int id) 
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
    }
}
