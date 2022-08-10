using System;
using System.ComponentModel.DataAnnotations;

namespace PGALtda.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        [MinLength(11, ErrorMessage = "Cpf inválido!")]
        public string Cpf { get; set; }
        public bool Ativo { get; set; }
        public DateTime DtCriacao { get; set; }
        public bool JaVinculado { get; set; }
    }
}