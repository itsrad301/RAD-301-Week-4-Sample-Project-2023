using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public interface IRepository<T> where T: class
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task<List<T>> Find(Expression<Func<T, bool>> predicate);
        
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);
        
    }
}
