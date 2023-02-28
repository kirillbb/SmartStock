using SmartStock.BLL.DTOs.OrderType;

namespace SmartStock.BLL.DTOs.ProductType
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public ICollection<OrderProductDto>? OrderProducts { get; set; }
    }
}