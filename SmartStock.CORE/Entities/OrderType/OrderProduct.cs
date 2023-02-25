using SmartStock.CORE.Entities.ProductType;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.CORE.Entities.OrderType
{
    public class OrderProduct
    {
        [Key]
        [Column("OrderProductId")]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public Order Order { get; set; }
        
        public Product Product { get; set; }
    }
}