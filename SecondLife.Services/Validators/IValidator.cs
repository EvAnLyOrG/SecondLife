using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Services.Validators
{
    public interface IValidator<T> where T : class
    {
        bool CanAdd(T obj);
        bool CanEdit(T obj);
        bool CanDelete(T obj);
        bool CanGet(T obj);
    }
}
