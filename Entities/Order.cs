using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_API.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; } = 0;
        public string Status { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; } = new DateOnly();

        public List<OrderItem> OrderItems { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
