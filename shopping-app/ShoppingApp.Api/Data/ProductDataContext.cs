using MongoDB.Driver;
using ShoppingApp.Api.Models;

namespace ShoppingApp.Api.Data
{
    public class ProductDataContext
    {
        public ProductDataContext(IConfiguration config)
        {
            var client = new MongoClient(config["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(config["DatabaseSettings:DatabaseName"]);

            Products = database.GetCollection<Product>(config["DatabaseSettings:CollectionName"]);
            SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; set; }

        private static void SeedData(IMongoCollection<Product> productCollection)
        {
            var existProducts = productCollection.Find(p => true).Any();

            if (!existProducts)
            {
                var seedProducts = GetSeedProducts();
                productCollection.InsertMany(seedProducts);
            }
        }

        private static IEnumerable<Product> GetSeedProducts() => new List<Product>
        {
              new Product
              {
                    Name = "IPhone X",
                    Description = "This phone is the tenth version of Apple mobiles",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "IPhone"
              },
              new Product
              {
                    Name = "Samsung M20",
                    Description = "This phone is the newest generation of Samsung mobiles",
                    ImageFile = "product-2.png",
                    Price = 1030.00M,
                    Category = "Samsung"
              },
              new Product
              {
                    Name = "Huawei Mate 20",
                    Description = "This phone is the most promising device of Huawei company",
                    ImageFile = "product-3.png",
                    Price = 600.00M,
                    Category = "Huawei"
              },
              new Product
              {
                    Name = "Xiaomi Mi 9",
                    Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    ImageFile = "product-4.png",
                    Price = 380.00M,
                    Category = "White Appliances"
              }
        };
    }
}
