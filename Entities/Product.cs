using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_API.Entities
{
    public class Product
    {
        public int id { get; set; }
        // Id of each products
        public string Mame { get; set; }
        // Name of each product 
        public string Description { get; set; } = string.Empty;
        // Description of each product and it can be empty
        public decimal Price { get; set; }
        // Price of one product
        public int stock { get; set; }
        //quantity of each product

        [ForeignKey("ProductCategory")]
        public int? Category { get; set; }
        // The key that links to the category table
        public Category? ProductCatogory { get; set; }
        //  navigation property — lets you access the full Category object
        //  the ? means it can be null (not always loaded)
    }
}
