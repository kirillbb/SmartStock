using SmartStock.BLL.DTOs.ProductType;
using SmartStock.BLL.Mappers;
using SmartStock.BLL.Services;
using SmartStock.BLL.ViewModels.ProductType;

namespace SmartStock.ConsoleApp
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            ProductService service = new ProductService();
            var products = Mapper<ProductDto, ProductViewModel>.MapAll(await service.GetPagedAsync(1, 10));

            var product = new ProductViewModel
            {
                Name = "New Sprite",
                Price = 10m,
                Stock = 10,
            };

            service.CreateAsync(Mapper<ProductViewModel, ProductDto>.Map(product));

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Stock}");
            }
        }
    }
}