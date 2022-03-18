using AutoMapper;
using GeekShopping.ProductAPI.Data.DTOs;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return  _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task<ProductDTO> FindById(long Id)
        {
            Product product = await _context.Products.Where(x => x.Id == Id).SingleOrDefaultAsync();

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> Create(ProductDTO item)
        {
            Product product = _mapper.Map<Product>(item);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> Update(ProductDTO item)
        {
            Product product = _mapper.Map<Product>(item);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<bool> Delete(long Id)
        {
            try
            {
                Product product = await _context.Products.Where(x => x.Id == Id).SingleOrDefaultAsync();

                if (product == null) return false;

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }        


    }
}
