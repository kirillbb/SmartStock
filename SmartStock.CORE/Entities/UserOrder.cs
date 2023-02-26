using SmartStock.CORE.Entities.OrderType;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.CORE.Entities
{
    public class UserOrder
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}