using System.Collections.Generic;

namespace PGALtda.Models
{
    public class VincularFuncionarioModel
    {
        public IEnumerable<UnidadeModel> Unidades { get; set; }
        public IEnumerable<FuncionarioModel> Funcionarios { get; set; }
        public int FuncionarioId { get; set; }
        public int UnidadeId { get; set; }
        public string FuncionarioNome { get; set; }
        public string UnidadeNome { get; set; }
    }
}
