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
    public class CategoryDataService : ICategory<Category>
    {
        private readonly MauiProductContext _context;
        public CategoryDataService(MauiProductContext productContext)
        {
            _context = productContext;
        }


        public Task Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> Find(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAll()
        {
            return _context.Categories
             .Include(c => c.Products).
             ThenInclude(p => p.Suppliers)
             .ToListAsync();
        }

        public Task Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }
    }
}
