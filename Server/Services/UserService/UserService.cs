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

        public List<UserDto> GetAll()
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
        /* proba K
        void IUserService.AddUser(UserDto userDto)
        {
            User user;
            user = new User();
            user.Email = "test@gmail.com";


            _context.Add(user);
            _context.SaveChanges();
        } */

        List<UserDto> IUserService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
