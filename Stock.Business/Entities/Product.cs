using System;

namespace Stock.Business.Entities
{
    public class Product : Entity
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public decimal UnitPrice { get; set; }
        public string Image { get; set; }
        
        
        public Guid CategoryProductId { get; set; }
        public CategoryProduct CategoryProduct { get; set; }

        public Guid IdSupplier { get; set; }
        public Supplier Supplier { get; set; }
    }
}
