using System.ComponentModel.DataAnnotations;

namespace Aula4.Models
{
    public class ProdutoViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Informe o nome do produto")]
        [StringLength(150, MinimumLength = 4)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A descrição do produto é obrigatória")]
        [StringLength(255, MinimumLength = 10)]
        public string Descricao { get; set; }
    }
}