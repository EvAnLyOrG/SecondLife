using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.JsonPatch;

namespace SecondLife.Services.Interfaces
{
    public interface IService<T> where T : class
    {
        List<T> List();
        T Get(int id);
        T Add(T annonce);
        T Patch(T id, JsonPatchDocument<T> jsonPatch);
        T Remove(T annonce);
    }
}
