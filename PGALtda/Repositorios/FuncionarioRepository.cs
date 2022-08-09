using PGALtda.Data;
using PGALtda.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PGALtda.Repositorios
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly BancoContext _context;
        private readonly IFuncionarioUnidadeRepository _funcionarioUnidadeRepository;   
        public FuncionarioRepository(BancoContext context, IFuncionarioUnidadeRepository funcionarioUnidadeRepository)
        {
            _context = context;
            _funcionarioUnidadeRepository = funcionarioUnidadeRepository;
        }
        public FuncionarioModel Cadastrar(FuncionarioModel funcionario)
        {
            var jaTemCpf = _context.Funcionarios.FirstOrDefault(x => x.Cpf == funcionario.Cpf && x.Ativo == true);
            if (jaTemCpf != null)
            {
                throw new System.Exception("Cpf já cadastrado!");
            }

            _context.Add(funcionario);
            funcionario.Ativo = true;
            funcionario.DtCriacao = DateTime.Now;
            _context.SaveChanges();
            return funcionario;
        }

        public void Inativar(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(x => x.Id == id && x.Ativo == true);
            if (funcionario == null) throw new System.Exception("Houve um erro ao inativar!");
            funcionario.Ativo = false;
            _context.SaveChanges();
        }

        public IEnumerable<FuncionarioModel> Listar()
        {
            return _context.Funcionarios.ToList().Where(x => x.Ativo == true);
        }

        public FuncionarioModel Obter(int id)
        {
            return _context.Funcionarios.FirstOrDefault(x => x.Id == id);
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
