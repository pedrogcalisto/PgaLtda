using System.Collections.Generic;

namespace PGALtda.Models.DTOs
{
    public class RelatorioDto
    {
        public int UnidadeId { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public List<FuncionarioDto> Funcionarios { get; set; }
    }
}
