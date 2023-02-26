using SmartStock.BLL.DTOs.OrderType;

namespace SmartStock.BLL.DTOs
{
    public class UserOrderDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public UserDto User { get; set; }

        public int OrderId { get; set; }

        public OrderDto Order { get; set; }
    }
}