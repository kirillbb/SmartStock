using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.BLL.DTOs.OrderTypeDTO
{
    public class OrderDto
    {
        [Key]
        [Column("OrderId")]
        public int Id { get; set; }

        [Required]
        public string CustomerId { get; set; }

        [Required]
        public string CustomerAddress { get; set; }


        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public OrderStatus Status { get; set; }
        
        public ICollection<OrderProductDto> OrderProducts { get; set; }
    }
}
