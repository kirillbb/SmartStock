using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.BLL.DTOs.OrderTypeDTO
{
    public class OrderDto
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public string CustomerAddress { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; }
        
        public ICollection<OrderProductDto> OrderProducts { get; set; }
    }
}
