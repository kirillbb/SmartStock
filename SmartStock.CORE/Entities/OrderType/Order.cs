using System.ComponentModel.DataAnnotations;

namespace SmartStock.CORE.Entities.OrderType
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public UserOrder UserOrder { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}