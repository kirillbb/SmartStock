using SmartStock.BLL.ViewModels.OrderType;

namespace SmartStock.BLL.ViewModels.ProductType
{
    internal class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public ICollection<OrderProductViewModel> OrderProducts { get; set; }
    }
}