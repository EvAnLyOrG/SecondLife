using Microsoft.AspNetCore.JsonPatch;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SecondLife.Services.Services
{
    public class GenericService<T> : IService<T> where T : class
    {
        private IRepository<T> _repo;

        public GenericService(IRepository<T> repo)
        {
            _repo = repo;
        }

        public T Add(T annonce)
        {
            return _repo.Add(annonce);
        }

        public T Get(in int id)
        {
            return _repo.One(id);
        }

        public List<T> List()
        {
            return _repo.All();
        }

        public T Patch(in int id, JsonPatchDocument<T> jsonPatch)
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
    public class AnnonceService : IAnnonceService
    {
        private IAnnonceRepository _repo;

        public AnnonceService(IAnnonceRepository repo)
        {
            _repo = repo;
        }

        public List<Annonce> List(Expression<Func<Annonce, bool>> condition)
        {
            return _repo.All(condition);
        }

        public Annonce Get(int id)
        {
            return _repo.Get(id);
        }

        public Annonce Add(Annonce annonce)
        {
            if (String.IsNullOrEmpty(annonce.Title))
            {
                return null;
            }

            if (_repo.Exists(annonce))
            {
                return null;
            }

            return _repo.Add(annonce);
        }

        public Annonce Patch(in int id, JsonPatchDocument<Annonce> document)
        {
            var updatedObject = Get(id);
            document.ApplyTo(updatedObject);
            _repo.Update(updatedObject);
            return updatedObject;
        }

        public Annonce Get(in int id)
        {
            return _repo.Get(id);
        }

        public Annonce Remove(Annonce annonce)
        {
            throw new NotImplementedException();
        }
    }
}
