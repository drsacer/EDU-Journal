using AutoMapper;
using EDU_Journal.Server.Data;
using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EDU_Journal.Server.Services
{
    public class UserService : IUserService // interfejs
    {
        private readonly JournalDbContext _context;
        private readonly IMapper _mapper;   

        public UserService(JournalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        
        public List<UserDto> GetAllUsers()
        {
            try
            {
                var data = _context.Users.ToList();
                return _mapper.Map<List<UserDto>>(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        } 

       
        public void AddUser (UserDto user)
        {
            var data = _mapper.Map<User>(user);

            _context.Users.Add(data);
            _context.SaveChanges();

        }

        public void UpdateUser(UserDto user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public UserDto GetUserData(int id)
        {
            User data = _context.Users.Find(id);
            UserDto u = _mapper.Map<UserDto>(data);
            return u;
        }

        public void DeleteUser(int id)
        {
            var data = _context.Users.Find(id);

            _context.Users.Remove(data);
            _context.SaveChanges();

        }
    }
}
