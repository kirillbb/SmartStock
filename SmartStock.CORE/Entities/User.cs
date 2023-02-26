using System.ComponentModel.DataAnnotations;

namespace SmartStock.CORE.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public ICollection<UserOrder>? UserOrders { get; set; }
    }
}