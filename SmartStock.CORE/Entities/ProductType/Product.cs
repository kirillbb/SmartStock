using SmartStock.CORE.Entities.OrderType;
using System.ComponentModel.DataAnnotations;

namespace SmartStock.CORE.Entities.ProductType
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}