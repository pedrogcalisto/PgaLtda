using System;

namespace PGALtda.Models
{
    public class FuncionarioUnidadeModel
    {
        public int FuncionarioId { get; set; }
        public int UnidadeId { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao { get; set; }
    }
}
