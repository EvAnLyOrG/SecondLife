using Microsoft.AspNetCore.JsonPatch;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SecondLife.Services.Interfaces;
using SecondLife.Services.Validators;

namespace SecondLife.Services.Services
{
    public class GenericService<T> : IService<T> where T : class
    {
        protected IRepository<T> _repo;
        protected IValidator<T> _validator;

        public GenericService(IRepository<T> repo, IValidator<T> validator)
        {
            _repo = repo;
            _validator = validator;
        }

        public T Add(T obj)
        {
            return _repo.Add(obj);
        }

        public T Get(int id)
        {
            return _repo.One(id);
        }

        public List<T> List()
        {
            return _repo.All();
        }

        public T Patch(T obj, JsonPatchDocument<T> jsonPatch)
        {
            throw new NotImplementedException();
        }

        public T Remove(T obj)
        {
            if (obj == null)
            {
                return null;
            }
            _repo.Remove(obj);
            return obj;
        }
    }
    
}
