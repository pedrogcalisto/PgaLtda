using System;
using System.Collections.Generic;

namespace PGALtda.Models
{
    public class FuncionarioUnidadeModel
    {
        public int UnidadeId { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DtAdmissao { get; set; }
        public DateTime? DtDemissao { get; set; }
    }
}
