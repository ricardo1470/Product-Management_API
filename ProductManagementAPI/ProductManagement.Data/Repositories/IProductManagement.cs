using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Data.Repositories
{
    public interface IProductManagement
    {
        Task<IEnumerable<ProductManagement>> GetAllProducts();
        Task<ProductManagement> GetProductDetails(int id);
    }
}
