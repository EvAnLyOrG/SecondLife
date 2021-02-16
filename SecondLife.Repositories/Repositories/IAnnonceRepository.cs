using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Repositories.Repositories
{
    public interface IAnnonceRepository
    {
        List<Annonce> All();
        Annonce One();
        Annonce Add(Annonce annonce);
        bool Exists(Annonce annonce);        
    }
}
