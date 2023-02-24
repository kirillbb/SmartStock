using System.ComponentModel.DataAnnotations;

namespace SmartStock.DAL.Entities.OrderType
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CustomerId { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Processing;
    }
}
