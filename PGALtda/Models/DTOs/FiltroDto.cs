using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace PGALtda.Models.DTOs
{
    public class FiltroDto
    {
        public int TipoRelatorio { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int UnidadeId { get; set; }
        public IEnumerable<UnidadeModel> Unidades { get; set; }
    }
}
