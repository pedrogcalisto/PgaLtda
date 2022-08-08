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
        public FuncionarioRepository(BancoContext context)
        {
            _context = context;
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
    }
}
