using SmartStock.BLL.DTOs.OrderTypeDTO;

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