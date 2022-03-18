using GeekShopping.ProductAPI.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository : IBaseRepository<ProductDTO>
    {
        //Task<IEnumerable<ProductDTO>> FindAll();
        //Task<ProductDTO> FindById(long Id);
        //Task<ProductDTO> Create(ProductDTO product);
        //Task<ProductDTO> Update(ProductDTO product);
        //Task<bool> Delete(long Id);
    }
}
