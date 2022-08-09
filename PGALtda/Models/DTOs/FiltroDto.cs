using System;

namespace PGALtda.Models.DTOs
{
    public class FiltroDto
    {
        public int TipoRelatorio { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
