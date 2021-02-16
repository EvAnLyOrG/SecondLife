using SecondLife.Model;
using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public class AnnonceRepository : IAnnonceRepository
    {
        private readonly AnnonceDbContext _context;

        public AnnonceRepository(AnnonceDbContext context)
        {
            _context = context;
        }

        public List<Annonce> All()
        {
            return _context.Annonces.ToList();
        }

        public Annonce One()
        {
            return _context.Annonces.FirstOrDefault();
        }

        public Annonce Add(Annonce annonce)
        {
            _context.Add(annonce);
            _context.SaveChanges();
            return annonce;
        }

        public bool Exists(Annonce annonce)
        {
            var dbAnnonce = _context.Annonces.FirstOrDefault(x => x.Title == annonce.Title);
            return dbAnnonce != null;
        }
    }
}
