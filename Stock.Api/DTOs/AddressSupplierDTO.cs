using System;
using System.ComponentModel.DataAnnotations;

namespace Stock.Api.DTOs
{
    public class AddressSupplierDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Road { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Number { get; set; }

        public string Complement { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string District { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string UF { get; set; }


        public Guid IdSupplier { get; set; }
    }
}
