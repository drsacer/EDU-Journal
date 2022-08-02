using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;

namespace EDU_Journal.Server.Services
{
    public interface IUserService
    {
        public void AddUser(UserDto userDto);
        public UserDto GetUserDataById(int id);
        public List<UserDto> GetAllUsers();
        public void UpdateUserById(int id);
        public void DeleteUserById(int id);
        void ChangePassword(int id, string password);
    }
}
