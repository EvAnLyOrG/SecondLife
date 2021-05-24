using System;
using System.Collections.Generic;
using System.Text;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;

namespace SecondLife.Services.Validators
{
    public class UserValidator : GenericValidator<User>, IValidator<User>
    {
        public UserValidator(IRepository<User> repo) : base(repo)
        {

        }
    }
}
