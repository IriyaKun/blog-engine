using System.Collections.Generic;
using BlogEngine.BLL.Helpers;
using BlogEngine.DLL.Models;

namespace BlogEngine.BLL.Interfaces
{
    public interface IBloggingRepository<T> where T:class
    {
        BlogOperationResult Add(T entity);
        BlogOperationResult Remove(T entity);
        BlogOperationResult Update(T entity);

        bool Exists(T entity);

        IEnumerable<T> ToEnumerable();
    }
}
