using Mongo.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pmApi.Models;

public class Products
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string ProductDescription { get; set; }
    public string ProductStatus { get; set; }
    public string ManufacturingDate { get; set; }
    public string ValidityDate { get; set; }
    public string SupplierCode { get; set; }
    public string SupplierDescription { get; set; }
    public string supplierPhone { get; set; }
}