namespace SmartStock.BLL.DTOs.OrderType
{
    public class OrderDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public UserOrderDto UserOrder { get; set; }

        public string CustomerAddress { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; }

        public ICollection<OrderProductDto>? OrderProducts { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
}