using SmartStock.BLL.DTOs.ProductTypeDTO;

namespace SmartStock.BLL.DTOs.OrderTypeDTO
{
    public class OrderProductDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public OrderDto Order { get; set; }

        public ProductDto Product { get; set; }
    }
}