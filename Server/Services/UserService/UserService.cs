﻿using AutoMapper;
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

        public void UpdateUserById(int id)
        {
            var data = _context.Users.Find(id);

            _context.Entry(data).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public UserDto GetUserDataById(int id)
        {
            var data = _context.Users.Find(id);
            return _mapper.Map<UserDto>(data);
        }

        public void DeleteUserById(int id)
        {
            var data = _context.Users.Find(id);

            _context.Users.Remove(data);
            _context.SaveChanges();

        }

        public void ChangePassword(int id, string password)
        {
            var user = _context.Users.Find(id);

            user.Password = password;
            _context.SaveChanges();
        }
    }
}
