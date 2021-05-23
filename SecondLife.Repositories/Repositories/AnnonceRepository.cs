using SecondLife.Model;
using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public class AnnonceRepository : GenericRepository<Annonce>, IRepository<Annonce>
    {

        public AnnonceRepository(SalesDbContext context) : base(context)
        {

        }

    } 
}
