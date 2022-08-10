using System;
using System.Collections.Generic;

namespace PGALtda.Models.DTOs
{
    public class RelatorioDto
    {
        public string UnidadeNome { get; set; }
        public string FuncionarioNome { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DtAdmissao { get; set; }
        public DateTime? DtDemissao { get; set; }
    }
}
