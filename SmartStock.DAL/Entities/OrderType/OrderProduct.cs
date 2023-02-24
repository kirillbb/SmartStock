using System.ComponentModel.DataAnnotations;

namespace SmartStock.DAL.Entities.OrderType
{
    public class OrderProduct
    {
        [Key]
        public int OrderProductId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}