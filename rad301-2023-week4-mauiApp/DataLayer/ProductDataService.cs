using Microsoft.EntityFrameworkCore;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace rad301_2023_week3_mauiApp.DataLayer
{
    public class ProductDataService : IProduct<Product>
    {
        private readonly MauiProductContext _context;
        public ProductDataService(MauiProductContext productContext)
        {
            _context = productContext;
        }


        public Task Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRange(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> Find(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAll()
        {
            return _context.Products
             .Include(p => p.Suppliers)
             .ToListAsync();
        }

        public Task Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRange(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }
    }
}
