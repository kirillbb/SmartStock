using SmartStock.BLL.ViewModels.OrderType;

namespace SmartStock.BLL.ViewModels
{
    internal class UserViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public ICollection<OrderViewModel>? Orders { get; set; }
    }
}