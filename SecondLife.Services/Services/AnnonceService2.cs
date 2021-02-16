using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Services.Services
{
    public class AnnonceService2 : IAnnonceService
    {
        public Annonce Add(Annonce film)
        {
            throw new NotImplementedException();
        }

        public Annonce Get(in int id)
        {
            throw new NotImplementedException();
        }

        public List<Annonce> List()
        {
            var annonces = new List<Annonce>();
            annonces.Add(new Annonce()
            {
                Id = 1,
                Title = "Mario Bros 98",
                Price = 50,
                Description = "Remise en main propre uniquement."
            });
            annonces.Add(new Annonce()
            {
                Id = 2,
                Title = "Zelda 80",
                Price = 80,
                Description = "Version collector. Sous scelée."
            });

            return annonces;
        }
    }
}
