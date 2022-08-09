using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PGALtda.Models
{
    public class FuncionarioUnidadeModel
    {
        [Key]
        public int Id { get; set; }
        public int UnidadeId { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DtAdmissao { get; set; }
        public DateTime? DtDemissao { get; set; }
    }
}
