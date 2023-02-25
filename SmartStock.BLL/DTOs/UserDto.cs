using SmartStock.BLL.DTOs.OrderTypeDTO;
using System.ComponentModel.DataAnnotations;

namespace SmartStock.BLL.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public ICollection<OrderDto>? Orders { get; set; }
    }
}