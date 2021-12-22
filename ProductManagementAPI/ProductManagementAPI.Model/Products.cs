using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementAPI.Model
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductDescription { get; set; }
        public string ProductStatus { get; set; }
        public int DateOfManufacture { get; set; }
        public int ValidityDate { get; set; }
        public int SupplierCode { get; set; }
        public string SupplierDescription { get; set; }
        public int SupplierPhoneNumber { get; set; }
    }
}
