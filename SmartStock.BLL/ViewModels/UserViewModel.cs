namespace SmartStock.BLL.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<UserOrderViewModel>? UserOrders { get; set; }
    }
}