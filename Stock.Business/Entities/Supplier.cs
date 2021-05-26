using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Entities
{
    public class Supplier : Entity
    {
        public string Name { get; set; }
        public int Doc { get; set; }
        public TypeSupplier TypeSupplier { get; set; }
        public Address Address { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
