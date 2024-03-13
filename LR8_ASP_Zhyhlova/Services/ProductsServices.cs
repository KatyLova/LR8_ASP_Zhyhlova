using LR8_ASP_Zhyhlova.Models;

namespace LR8_ASP_Zhyhlova.Services
{
    public class ProductsServices : IProductsServices
    {
        private readonly Random _random = new();

        private static readonly string[] Names =
        {
        "Audi A4",
        "Chevrolet Lacetti",
        "Mercedes-Benz E220",
        "BMW 530d",
        "Toyota LandCruiser 200",
        "Toyota Camry",
        "Volkswagen Passat B6",
        "Volkswagen Golf V",
        "Skoda Octavia RS",
        "Ford Mustang GT"
        };

        public Product[] GetProducts()
        {
            return Enumerable.Range(0, 10)
                .Select((_, i) =>
                    CreateProduct((uint)(i + 1), (uint)_random.Next(5000, 30000)))
                .ToArray();
        }

        private Product CreateProduct(uint id, uint price)
        {
            return new Product
            {
                Id = id,
                Price = price,
                Name = RandomizeName(),
                CreatedDate = DateTime.Now
            };
        }

        private string RandomizeName()
        {
            return Names[_random.Next(0, Names.Length)];
        }
    }
}
