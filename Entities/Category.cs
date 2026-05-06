using System.Security.Cryptography.Xml;

namespace E_commerce_API.Entities
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new List<Product>();
        

    }
}
XmlDsigXPathTransform\\]kjk