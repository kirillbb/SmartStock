using SmartStock.BLL.DTOs.OrderType;

namespace SmartStock.BLL.ViewModels.OrderType
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public UserOrderViewModel UserOrder { get; set; }

        public string CustomerAddress { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; }

        public ICollection<OrderProductViewModel> OrderProducts { get; set; }
    }
}