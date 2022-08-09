using System;

namespace PGALtda.Models.DTOs
{
    public class FuncionarioDto
    {
        public FuncionarioDto(FuncionarioModel model)
        {
            this.Id = model.Id;
            this.Idade = model.Idade;
            this.Cpf = OcultarCpf(model.Cpf); //ocultar CPF
            this.Nome = model.Nome;
            this.Ativo = model.Ativo;
            
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public bool Ativo { get; set; }
        private string OcultarCpf(string cpf)
        {
            return cpf.Substring(0, 3);
        }
    }
}
