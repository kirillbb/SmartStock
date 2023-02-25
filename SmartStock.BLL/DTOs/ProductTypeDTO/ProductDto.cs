using SmartStock.BLL.DTOs.OrderTypeDTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartStock.BLL.DTOs.ProductTypeDTO
{
    public class ProductDto
    {
        [Key]
        [Column("ProductId")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        public ICollection<OrderProductDto> OrderProducts { get; set; }
    }
}