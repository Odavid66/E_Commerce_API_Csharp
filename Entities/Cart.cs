using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_API.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public DateOnly CreatedAt { get; set; } = global::System.DateOnly.FromDateTime(global::System.DateTime.UtcNow);

        public List<CartItem> CartItems { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
