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
<<<<<<< HEAD
            var relatorio = _context.FuncionarioUnidade.Where(x => x.DtAdmissao >= filtro.DataInicial && x.DtAdmissao <= filtro.DataFinal && x.UnidadeId == filtro.UnidadeId ||
             x.DtDemissao >= filtro.DataInicial && x.DtDemissao <= filtro.DataFinal && x.UnidadeId == filtro.UnidadeId);
=======
            var relatorio = _context.FuncionarioUnidade.Where(x => x.DtAdmissao >= filtro.DataInicial && x.DtAdmissao <= filtro.DataFinal ||
             x.DtDemissao >= filtro.DataInicial && x.DtDemissao <= filtro.DataFinal);
            //gerar relatorio por tipo
>>>>>>> 20d5163f9e5c0c283e1f66c77d95c006d06f74a3

            
            return relatorio.ToList();
        }
    }
}
