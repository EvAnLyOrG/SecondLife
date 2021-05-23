using Microsoft.AspNetCore.JsonPatch;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SecondLife.Services.Interfaces;

namespace SecondLife.Services.Services
{
    public class GenericService<T> : IService<T> where T : class
    {
        protected IRepository<T> _repo;
        //private IValidator<T> _validator;

        public GenericService(IRepository<T> repo)
        {
            _repo = repo;
        }

        public T Add(T annonce)
        {
            return _repo.Add(annonce);
        }

        public T Get(int id)
        {
            return _repo.One(id);
        }

        public List<T> List()
        {
            return _repo.All();
        }

        public T Patch(T annonce, JsonPatchDocument<T> jsonPatch)
        {
            throw new NotImplementedException();
        }

        public T Remove(T annonce)
        {
            if (annonce == null)
            {
                return null;
            }
            _repo.Remove(annonce);
            return annonce;
        }
    }
    
}
