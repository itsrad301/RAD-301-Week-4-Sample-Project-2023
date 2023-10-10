using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public interface ICategory<T> : IRepository<T> where T : Category
    {
        // Might want to implement specific Product functionality Later
    }
}
