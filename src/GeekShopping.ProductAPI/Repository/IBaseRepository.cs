using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(long Id);
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task<bool> Delete(long Id);
    }
}
