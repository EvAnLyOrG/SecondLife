using Google;
using Microsoft.EntityFrameworkCore;
using SecondLife.Model.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationContext context;

        public UserRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetUsersByID(int usersId)
        {
            return context.Users.Find(usersId);
        }

        public void InsertUsers(User users)
        {
            context.Users.Add(users);
        }

        public void DeleteUsers(int usersId)
        {
            User users = context.Users.Find(usersId);
            context.Users.Remove(users);
        }

        public void UpdateUsersr(User users)
        {
            context.Entry(users).State = EntityState.Modified;
        }

        public void Save()
        {
            object p = context.SaveChanges();
        }

        IEnumerable IUserRepository.GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUsers(User users)
        {
            throw new NotImplementedException();
        }
    }
}
