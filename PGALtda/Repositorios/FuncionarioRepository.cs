using PGALtda.Data;
using PGALtda.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PGALtda.Repositorios
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly IBancoContext _context;
        private readonly IFuncionarioUnidadeRepository _funcionarioUnidadeRepository;   
        public FuncionarioRepository(IBancoContext context, IFuncionarioUnidadeRepository funcionarioUnidadeRepository)
        {
            _context = context;
            _funcionarioUnidadeRepository = funcionarioUnidadeRepository;
        }
        public FuncionarioModel Cadastrar(FuncionarioModel funcionario)
        {
            var jaTemCpf = _context.Funcionarios.Find(funcionario.Id);
            if (jaTemCpf != null)
            {
                throw new System.Exception("Cpf já cadastrado!");
            }

            funcionario.Ativo = true;
            _context.SaveChanges();
            return funcionario;
        }

        public bool Inativar(int id)
        {
            try
            {
                var funcionario = _context.Funcionarios.Find(id);
                if (funcionario == null) throw new System.Exception("Houve um erro ao inativar!");
                funcionario.Ativo = false;
                _context.SaveChanges();
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
        public FuncionarioModel Lstar()
        {
            return _context.Funcionarios.Find();
        }
        public List<FuncionarioModel> Listar()
        {
            return _context.Funcionarios.ToList();
        }

        public FuncionarioModel Obter(int id)
        {
            return _context.Funcionarios.Find(id);
        }

        public IEnumerable<FuncionarioModel> ListarFuncionariosSemVinculo()
        {
            var funcionarios = _context.Funcionarios.ToList().Where(x => x.Ativo == true);
            var funcionariosVinculados = _context.FuncionarioUnidade.ToList().Where(x => x.DtDemissao != null);
            List<FuncionarioModel> funcionarioNaoVinculados = new List<FuncionarioModel>();

            foreach(var funcionario in funcionarios)
            {
                var temFuncionario = funcionariosVinculados.FirstOrDefault(x => x.FuncionarioId == funcionario.Id);
                if (temFuncionario == null)
                {
                    funcionarioNaoVinculados.Add(funcionario);
                }
            }

            return funcionarioNaoVinculados;
        }
    }
}
