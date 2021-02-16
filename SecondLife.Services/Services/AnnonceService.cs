using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Services.Services
{
    public class AnnonceService : IAnnonceService
    {
        private IAnnonceRepository _repo;

        public AnnonceService(IAnnonceRepository repo)
        {
            _repo = repo;
        }

        public List<Annonce> List()
        {
            return _repo.All();
        }

        public Annonce Get(in int id)
        {
            return _repo.One();
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
    }
}
