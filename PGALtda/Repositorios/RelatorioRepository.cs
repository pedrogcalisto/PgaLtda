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
        public List<RelatorioDto> ObterDados(FiltroDto filtro)
        {
            List<FuncionarioUnidadeModel> relatorioFuncionarioUnidade = new List<FuncionarioUnidadeModel>();
            if (filtro.TipoRelatorio == 1)
            {
                relatorioFuncionarioUnidade = _context.FuncionarioUnidade.Where(x => x.DtAdmissao >= filtro.DataInicial && x.DtAdmissao <= filtro.DataFinal && x.UnidadeId == filtro.UnidadeId).ToList();
            } else
            {
                relatorioFuncionarioUnidade = _context.FuncionarioUnidade.Where(x => x.DtDemissao >= filtro.DataInicial && x.DtDemissao <= filtro.DataFinal && x.UnidadeId == filtro.UnidadeId).ToList();
            }
            RelatorioDto relatorio = new RelatorioDto();
            List<RelatorioDto> relatorioList = new List<RelatorioDto>();
            foreach(var item in relatorioFuncionarioUnidade)
            {
                relatorio.FuncionarioNome = _context.Funcionarios.FirstOrDefault(x => x.Id == item.FuncionarioId).Nome;
                relatorio.UnidadeNome = _context.Unidades.FirstOrDefault(x=>x.Id == item.UnidadeId).Nome;
                relatorio.FuncionarioId = item.FuncionarioId;
                relatorio.DtDemissao = item.DtDemissao;
                relatorio.DtAdmissao = item.DtAdmissao;
                relatorioList.Add(relatorio);
            }
            
            return relatorioList;
        }
    }
}
