using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Model
{
    public class ProductManagement
    {
        public int Id { get; set; }

        public string ProductDescription { get; set; }

        public bool ProductStatus { get; set; }

        public int DateOfManufacture { get; set; }

        public int ValidityDate { get; set; }

        public int SupplierCode { get; set; }

        public string SupplierDescription { get; set; }

        public int SupplierPhoneNumber { get; set; }

    }
}
