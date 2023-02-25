using SmartStock.BLL.DTOs.OrderType;

namespace SmartStock.BLL.ViewModels.OrderType
{
    internal class OrderViewModel
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public string CustomerAddress { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; }

        public ICollection<OrderProductViewModel> OrderProducts { get; set; }
    }
}