using System.Collections.Generic;

namespace Stock.Business.Entities
{
    public class CategoryProduct : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
