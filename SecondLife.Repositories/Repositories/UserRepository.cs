using System;
using System.Collections.Generic;
using System.Text;
using SecondLife.Model;
using SecondLife.Model.Entities;

namespace SecondLife.Repositories.Repositories
{
    public class UserRepository : AnnonceRepository<User>, IRepository<User>
    {
        public UserRepository(SalesDbContext context) : base(context) { }
    }
}
