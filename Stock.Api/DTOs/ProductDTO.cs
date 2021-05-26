using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Api.DTOs
{
    public class ProductDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public int Amount { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Desciption { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public decimal UnitPrice { get; set; }

        public string Image { get; set; }
        public string ImageUpload { get; set; }

        public bool Ativo { get; set; }

        public Guid CategoryProductId { get; set; }

        public Guid IdSupplier { get; set; }
        public string NameSupplier { get; set; }

    }
}
