using System.ComponentModel.DataAnnotations;

namespace sonmarket.DTO
{
    public class ProdutoDTO
      
    {
        [Required]
        public int Id {get; set;}



        [Required(ErrorMessage="Nome é obrigatório!")]
        [StringLength(50, ErrorMessage="Nome com excesso de caracteres!")]
        [MinLength(2,ErrorMessage="Nome muito curto!")]
        public string Nome {get; set;}
        


        [Required(ErrorMessage="Categoria é obrigatório!")]
        public int CategoriaID {get; set;}



        [Required(ErrorMessage="Fornecedor é obrigatório!")]
        public int FornecedorID {get; set;}



        [Required(ErrorMessage="Preço de custo do produto é obrigatório!")]
        public float PrecoDeCusto {get; set;}



        [Required(ErrorMessage="Preço de custo do produto é obrigatório!")]
        public string PrecoDeCustoString {get; set;}



        [Required(ErrorMessage="Preço de venda do produto é obrigatório!")]
        public float PrecoDeVenda {get; set;}
       
       
       
        [Required(ErrorMessage="Preço de venda do produto é obrigatório!")]
        public string PrecoDeVendaString {get; set;}
        
        
        
        [Required(ErrorMessage="Medição do produto é obrigatório!")]
        [Range(0,2,ErrorMessage="Medição Inválida!")]
        public int Medicao {get; set;}

       
    }
}