using System;
using System.Collections.Generic;
using System.Text;
using SecondLife.Services.Interfaces;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using Microsoft.AspNetCore.JsonPatch;

namespace SecondLife.Services.Services
{
    public class AnnonceService : GenericService<Annonce>, IAnnonceService
    {

        public AnnonceService(IRepository<Annonce> repo) : base(repo)
        {
            _repo = repo;
        }

        public List<Annonce> List()
        {
            return _repo.All();
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
