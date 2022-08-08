using System.ComponentModel.DataAnnotations;

namespace PGALtda.Models
{
    public class UnidadeModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome da unidade")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Digite a cidade da unidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage ="Digite o Cnpj da unidade")]
        [MinLength(14, ErrorMessage ="Cnpj inválido!")]
        public string Cnpj { get; set; }
        public bool Ativo { get; set; }
    }
}
