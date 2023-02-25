using SmartStock.BLL.ViewModels.ProductType;

namespace SmartStock.BLL.ViewModels.OrderType
{
    internal class OrderProductViewModel
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public OrderViewModel Order { get; set; }

        public ProductViewModel Product { get; set; }
    }
}