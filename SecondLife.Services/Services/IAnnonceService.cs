using Microsoft.AspNetCore.JsonPatch;
using SecondLife.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SecondLife.Services.Services
{
    public interface IAnnonceService : IService<Annonce>
    {
    }

    public interface IService<T> where T : class
    {
        public List<T> List(Expression<Func<T, bool>> condition);
        T Get(in int id);
        T Add(T annonce);
        T Patch(in int id, JsonPatchDocument<T> jsonPatch);
        T Remove(T annonce);
    }
}