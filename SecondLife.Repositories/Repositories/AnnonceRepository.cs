using SecondLife.Model;
using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SecondLife.Repositories.Repositories
{

    public class AnnonceRepository : Repository<Annonce>, IAnnonceRepository
    {
        public AnnonceRepository(AnnonceDbContext context) : base(context)
        {

        }

        public Annonce One(Expression<Func<Annonce, bool>> condition)
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

        public void Update(Annonce updatedObject)
        {
            _context.Attach(updatedObject);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            if (obj == null) return false;

            _context.Annonces.Remove(obj);
            _context.SaveChanges();
            return Get(id) == null;
        }

        public Annonce Get(int id)
        {
            return _context.Annonces.FirstOrDefault(x => x.Id == id);
        }
    }
}
