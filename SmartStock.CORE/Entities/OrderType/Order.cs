using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.CORE.Entities.OrderType
{
    public class Order
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
        
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
