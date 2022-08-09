using System;
using System.ComponentModel.DataAnnotations;

namespace PGALtda.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do funcionário")]
        public string Nome { get; set; }
        [MinLength(1, ErrorMessage = "Digite a idade do funcionário")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "Digite o Cpf do funcionário")]
        [MinLength(11, ErrorMessage = "Cpf inválido!")]
        public string Cpf { get; set; }
        public bool Ativo { get; set; }
        public DateTime DtCriacao { get; set; }
        public bool JaVinculado { get; set; }
    }
}