using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services
{
    public interface IUserService
    {
        public List<UserDto> GetAll();       
    }
}
