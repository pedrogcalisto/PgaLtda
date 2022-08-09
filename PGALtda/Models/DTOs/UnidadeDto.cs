namespace PGALtda.Models.DTOs
{
    public class UnidadeDto
    {
        public UnidadeDto(UnidadeModel model)
        {
            this.Id = model.Id;
            this.Cidade = model.Cidade;
            this.Nome = model.Nome;
            this.Cnpj = OcultarCnpj(model.Cnpj);//ocultar 
            this.Ativo = model.Ativo;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Cnpj { get; set; }
        public bool Ativo { get; set; }
        private string OcultarCnpj(string cpf)
        {
            return cpf.Substring(0, 3);
        }
    }
}
