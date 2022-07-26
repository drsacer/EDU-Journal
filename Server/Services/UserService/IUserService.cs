using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services
{
    public interface IUserService
    {
        public List<UserDto> GetAllUsers();
        void AddUser(UserDto userDto);
        void UpdateUser(UserDto userDto);
        UserDto GetUserData(int id);
        void DeleteUser(int id);
        void ChangePassword(int id, string password);
    }
}
