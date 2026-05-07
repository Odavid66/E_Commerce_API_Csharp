using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_API.Entities
{
    public class CartItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("CartId")]
        public Cart Cart { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
