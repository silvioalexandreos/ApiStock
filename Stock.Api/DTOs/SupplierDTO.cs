using Stock.Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stock.Api.DTOs
{
    public class SupplierDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public int Doc { get; set; }

        public int TypeSupplier { get; set; }
        public Address Address { get; set; }

        public bool Ativo { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
