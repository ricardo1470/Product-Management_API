using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime DateOfManufacture { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime ValidityDate { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierDescription { get; set; }
        public string SupplierPhoneNumber { get; set; }
    }
}
