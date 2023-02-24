using System.ComponentModel.DataAnnotations;

namespace SmartStock.DAL.Entities.OrderType
{
    internal class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}