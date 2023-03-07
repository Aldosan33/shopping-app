using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingApp.Api.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement(elementName: "name")]
        public string Name { get; set; }

        [BsonElement(elementName: "category")]
        public string Category { get; set; }

        [BsonElement(elementName: "description")]
        public string Description { get; set; }

        [BsonElement(elementName: "imageFile")]
        public string ImageFile { get; set; }

        [BsonElement(elementName: "price")]
        public decimal Price { get; set; }
    }
}
