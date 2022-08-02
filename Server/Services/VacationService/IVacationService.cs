using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services.VacationService
{
    public interface IVacationService
    { 
        public void CreateVacation(VacationDto vacation);
        public VacationDto GetVacationById(int id);
        public List<VacationDto> GetAllVacations();
        public void UpdateVacation(int id);
        public void DeleteVacation(int id);
    }
}
