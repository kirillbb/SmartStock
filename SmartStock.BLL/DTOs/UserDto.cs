namespace SmartStock.BLL.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<UserOrderDto>? UserOrders { get; set; }
    }
}