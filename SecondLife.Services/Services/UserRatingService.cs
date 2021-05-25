using System;
using System.Collections.Generic;
using SecondLife.Services.Interfaces;
using SecondLife.Services.Validators;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using Microsoft.AspNetCore.JsonPatch;

namespace SecondLife.Services.Services
{
    public class UserRatingService : GenericService<UserRating>, IUserRatingService
    {
        public UserRatingService(IRepository<UserRating> repo, IValidator<UserRating> validator) : base(repo, validator)
        {
            _repo = repo;
        }

        public List<UserRating> FindAll()
        {
            return _repo.All();
        }

        public UserRating Get(int id)
        {
            return _repo.One(id);
        }

        public UserRating Add(UserRating user)
        {
            if (String.IsNullOrEmpty(user.Comment))
            {
                return null;
            }

            if (_repo.Exists(user))
            {
                return null;
            }

            return _repo.Add(user);
        }

        public UserRating Patch(int id, JsonPatchDocument<UserRating> document)
        {
            var updatedObject = Get(id);
            document.ApplyTo(updatedObject);
            _repo.Update(updatedObject);
            return updatedObject;
        }

        public UserRating Remove(UserRating user)
        {
            throw new NotImplementedException();
        }
    }
}
