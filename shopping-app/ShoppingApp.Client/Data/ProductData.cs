using ShoppingApp.Client.Models;

namespace ShoppingApp.Client.Data
{
    public class ProductData
    {
        public static readonly IEnumerable<Product> products = new List<Product>
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
