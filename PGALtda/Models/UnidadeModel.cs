using System;
using System.ComponentModel.DataAnnotations;

namespace PGALtda.Models
{
    public class UnidadeModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        [MinLength(14, ErrorMessage ="Cnpj inválido!")]
        public string Cnpj { get; set; }
        public bool Ativo { get; set; }
        public DateTime DtCriacao { get; set; }
    }
}
