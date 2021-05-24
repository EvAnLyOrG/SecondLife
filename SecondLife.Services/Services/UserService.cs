using System;
using System.Collections.Generic;
using System.Text;
using SecondLife.Services.Interfaces;
using SecondLife.Services.Validators;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using Microsoft.AspNetCore.JsonPatch;

namespace SecondLife.Services.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IRepository<User> repo, IValidator<Annonce> validator) : base(repo, validator)
        {
            _repo = repo;
        }

        public List<User> FindAll()
        {
            return _repo.All();
        }

        public User Get(int id)
        {
            return _repo.One(id);
        }

        public User Add(User annonce)
        {
            if (String.IsNullOrEmpty(annonce.Email))
            {
                return null;
            }

            if (_repo.Exists(annonce))
            {
                return null;
            }

            return _repo.Add(annonce);
        }

        public User Patch(int id, JsonPatchDocument<User> document)
        {
            var updatedObject = Get(id);
            document.ApplyTo(updatedObject);
            _repo.Update(updatedObject);
            return updatedObject;
        }

        public User Remove(User annonce)
        {
            throw new NotImplementedException();
        }
    }
}
