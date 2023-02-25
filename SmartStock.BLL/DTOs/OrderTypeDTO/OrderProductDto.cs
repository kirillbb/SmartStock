using SmartStock.BLL.DTOs.ProductTypeDTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.BLL.DTOs.OrderTypeDTO
{
    public class OrderProductDto
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

        public OrderDto Order { get; set; }
        
        public ProductDto Product { get; set; }
    }
}