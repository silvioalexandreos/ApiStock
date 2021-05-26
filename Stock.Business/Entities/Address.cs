using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Entities
{
    public class Address : Entity
    {
        public string Road { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Cep { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string UF { get; set; }


        public Guid IdSupplier { get; set; }
        public Supplier Supplier { get; set; }

    }
}
