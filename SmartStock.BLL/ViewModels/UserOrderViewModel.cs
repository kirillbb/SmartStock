using SmartStock.BLL.ViewModels.OrderType;

namespace SmartStock.BLL.ViewModels
{
    public class UserOrderViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public UserViewModel User { get; set; }

        public int OrderId { get; set; }

        public OrderViewModel Order { get; set; }
    }
}