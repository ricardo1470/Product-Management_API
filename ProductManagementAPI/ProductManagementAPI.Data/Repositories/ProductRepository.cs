using Dapper;
using Npgsql;
using ProductManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAPI.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DataBaseConfiguration _connectionString;

        public ProductRepository(DataBaseConfiguration connectionString) => _connectionString = connectionString;

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> DeleteProducts(Products products)
        {
            var db = dbConnection();

            var sql = @"
                        DELETE FROM public.products
                        WHERE id = @Id";

            var result = await db.ExecuteAsync(sql, new { Id = products.Id });
            return result > 0;
        }

        public async Task<IEnumerable<Products>> GetAllProducts()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id, productdescription, productstatus, dateofmanufacture, validitydate, suppliercode, supplierdescription, supplierphonenumber
                        FROM public.products";

            return await db.QueryAsync<Products>(sql, new {});
        }

        public async Task<Products> GetProductsDetails(int id)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id, productdescription, productstatus, dateofmanufacture, validitydate, suppliercode, supplierdescription, supplierphonenumber
                        FROM public.products
                        WHERE id = ID";

            return await db.QueryFirstOrDefaultAsync<Products>(sql, new { Id = id });
        }

        public async Task<bool> InserProducts(Products products)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO public.products (productdescription, productstatus, dateofmanufacture, validitydate, suppliercode, supplierdescription, supplierphonenumber)
                        VALUES (@Productdescription, @Productstatus, @Dateofmanufacture, @Validitydate, @Suppliercode, @Supplierdescription, @Supplierphonenumber) ";

            var result =  await db.ExecuteAsync(sql, new { products.ProductDescription, products.ProductStatus, products.DateOfManufacture, products.ValidityDate, products.SupplierCode, products.SupplierDescription, products.SupplierPhoneNumber });
            return result > 0;
        }

        public async Task<bool> UpdateProducts(Products products)
        {
            var db = dbConnection();

            var sql = @"
                        UPDATE public.products
                        SET productdescription = @Productdescription,
                            productstatus = @Productstatus,
                            dateofmanufacture = @Dateofmanufacture,
                            validitydate = @Validitydate,
                            suppliercode = @Suppliercode,
                            supplierdescription = @Supplierdescription,
                            supplierphonenumber = @Supplierphonenumber
                        WHERE id = @Id ";

            var result = await db.ExecuteAsync(sql, new { products.Id, products.ProductDescription, products.ProductStatus, products.DateOfManufacture, products.ValidityDate, products.SupplierCode, products.SupplierDescription, products.SupplierPhoneNumber });
            return result > 0;
        }
    }
}
