using PGALtda.Data;
using PGALtda.Models;
using PGALtda.Models.DTOs;
using PGALtda.Repositorios.Interface;
using System.Collections.Generic;
using System.Linq;

namespace PGALtda.Repositorios
{
    public class RelatorioRepository : IRelatorioRepository
    {
        private readonly BancoContext _context;
        public RelatorioRepository(BancoContext context)
        {
            _context = context;
        }
        public List<FuncionarioUnidadeModel> ObterDados(FiltroDto filtro)
        {
            var relatorio = _context.FuncionarioUnidade.Where(x => x.DataAdmissao >= filtro.DataInicial && x.DataAdmissao <= filtro.DataFinal ||
             x.DataDemissao >= filtro.DataInicial && x.DataDemissao <= filtro.DataFinal);

            
            return relatorio.ToList();
        }
    }
}
