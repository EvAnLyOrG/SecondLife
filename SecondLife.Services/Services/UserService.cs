using System;
using System.Collections.Generic;
using System.Text;
using SecondLife.Services.Interfaces;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;

namespace SecondLife.Services.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IRepository<User> repo) : base(repo)
        {
            _repo = repo;
        }

        public List<User> Find()
        {
            return _repo.All();
        }
    }
}
