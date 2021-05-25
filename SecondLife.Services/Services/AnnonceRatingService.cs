using System;
using System.Collections.Generic;
using SecondLife.Services.Interfaces;
using SecondLife.Services.Validators;
using SecondLife.Model.Entities;
using SecondLife.Repositories.Repositories;
using Microsoft.AspNetCore.JsonPatch;

namespace SecondLife.Services.Services
{
    public class AnnonceRatingService : GenericService<AnnonceRating>, IAnnonceRatingService
    {
        public AnnonceRatingService(IRepository<AnnonceRating> repo, IValidator<AnnonceRating> validator) : base(repo, validator)
        {
            _repo = repo;
        }

        public List<AnnonceRating> List()
        {
            return _repo.All();
        }

        public AnnonceRating Get(int id)
        {
            return _repo.One(id);
        }

        public AnnonceRating Add(AnnonceRating annonceRating)
        {
            if (String.IsNullOrEmpty(annonceRating.Comment))
            {
                return null;
            }

            if (_repo.Exists(annonceRating))
            {
                return null;
            }

            return _repo.Add(annonceRating);
        }

        public AnnonceRating Patch(int id, JsonPatchDocument<AnnonceRating> document)
        {
            var updatedObject = Get(id);
            document.ApplyTo(updatedObject);
            _repo.Update(updatedObject);
            return updatedObject;
        }

        public AnnonceRating Remove(AnnonceRating annonceRating)
        {
            throw new NotImplementedException();
        }
    }
}
