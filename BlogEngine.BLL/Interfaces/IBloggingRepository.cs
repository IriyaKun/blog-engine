using System.Collections.Generic;
using BlogEngine.BLL.Helpers;
using BlogEngine.DLL.Models;

namespace BlogEngine.BLL.Interfaces
{
    public interface IBloggingRepository
    {
        BlogOperationResult Add(IModel entity);
        BlogOperationResult Remove();
        BlogOperationResult Update(IModel entity);

        IEnumerable<IModel> ToEnumerable();
    }
}
