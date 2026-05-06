using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_API.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public DateOnly CreatedAt { get; set; } = new DateOnly();

        public List<CartItem> CartItems { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
