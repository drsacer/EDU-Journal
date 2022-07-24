using AutoMapper;
using EDU_Journal.Server.Data;
using EDU_Journal.Server.Entities;
using EDU_Journal.Shared.DTOs;

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


        public void AddUser (UserDto userDto)
        {
            var data = _mapper.Map<User>(userDto);

            _context.Users.Add(data);
            _context.SaveChanges();

        }
    }
}
