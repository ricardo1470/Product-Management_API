using ProductManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAPI.Data.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Products>> GetAllProducts();
        Task<Products> GetProductsDetails(int id);
        Task<bool> InserProducts(Products products);
        Task<bool> UpdateProducts(Products products);
        Task<bool> DeleteProducts(Products products);
    }
}
