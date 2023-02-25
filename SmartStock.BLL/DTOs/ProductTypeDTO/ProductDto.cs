using SmartStock.BLL.DTOs.OrderTypeDTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.BLL.DTOs.ProductTypeDTO
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public ICollection<OrderProductDto> OrderProducts { get; set; }
    }
}