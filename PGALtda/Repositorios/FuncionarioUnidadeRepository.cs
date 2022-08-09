using PGALtda.Data;
using PGALtda.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PGALtda.Repositorios
{
    public class FuncionarioUnidadeRepository : IFuncionarioUnidadeRepository
    {
        private readonly BancoContext _context;
        public FuncionarioUnidadeRepository(BancoContext context)
        {
            _context = context;
        }

        public FuncionarioUnidadeModel Vincular (FuncionarioUnidadeModel model)
        {
            _context.Add(model);
            model.DtAdmissao = DateTime.Now;
            _context.SaveChanges();
            var funcionario = _context.Funcionarios.FirstOrDefault(x=>x.Id == model.FuncionarioId);
            funcionario.JaVinculado = true;
            _context.SaveChanges();
            return model;
        }

        public void DemitirFuncionario (int id)
        {
            var funcionario = _context.FuncionarioUnidade.FirstOrDefault(x => x.FuncionarioId == id && x.DtDemissao == null);
            funcionario.DtDemissao = DateTime.Now;
            var funcionariomodel = _context.Funcionarios.FirstOrDefault(x => x.Id == funcionario.FuncionarioId);
            funcionariomodel.JaVinculado = false;
            _context.SaveChanges();
        }

        public IEnumerable<FuncionarioUnidadeModel> Listar()
        {
            var funcionariosUnidades = _context.FuncionarioUnidade.ToList().Where(x => x.DtDemissao == null);
            return funcionariosUnidades;
        }

        public VincularFuncionarioModel Obter(int IdFuncionario) 
        {
            var funcionarioEunidade = _context.FuncionarioUnidade.FirstOrDefault(x => x.FuncionarioId == IdFuncionario && x.DtDemissao == null);       
            VincularFuncionarioModel funcionarioVinculado = new VincularFuncionarioModel();
            funcionarioVinculado.FuncionarioNome = _context.Funcionarios.FirstOrDefault(x => x.Id == funcionarioEunidade.FuncionarioId).Nome;
            funcionarioVinculado.FuncionarioId = funcionarioEunidade.FuncionarioId;
            funcionarioVinculado.UnidadeNome = _context.Unidades.FirstOrDefault(x => x.Id == funcionarioEunidade.UnidadeId).Nome;
            return funcionarioVinculado;
        }

    }
}
