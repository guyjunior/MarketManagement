using System.ComponentModel.DataAnnotations;

namespace sonmarket.DTO
{
    public class CategoriaDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage="Nome de categoria é obrigatório")]
        [StringLength(50,ErrorMessage="Nome muito grande!")]
        [MinLength(2,ErrorMessage="Nome muito pequeno!")]
        public string Nome {get; set;}

    }
}