using SmartStock.CORE.Entities.OrderType;
using System.ComponentModel.DataAnnotations;

namespace SmartStock.CORE.Entities
{
    internal class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}