using System.ComponentModel.DataAnnotations;

namespace sonmarket.DTO
{
    public class FornecedorDTO
    {
        [Required]
        public int Id {get; set;}


        [Required(ErrorMessage="Nome de fornecedor é obrigatório")]
        [StringLength(50,ErrorMessage="Nome muito grande!")]
        [MinLength(2,ErrorMessage="Nome muito pequeno!")]
        public string Nome {get; set;}


        [Required(ErrorMessage="E-mail de fornecedor é obrigatório")]
        [EmailAddress(ErrorMessage="E-mail inválido!")]
        
        public string Email {get; set;}


        [Required(ErrorMessage="Telefone de fornecedor é obrigatório")]
        [Phone(ErrorMessage="Telefone inválido!")]
        public string Telefone {get; set;}

    }
}