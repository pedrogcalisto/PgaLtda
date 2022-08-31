using PGALtda.Data;
using PGALtda.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PGALtda.Repositorios
{
    public class UnidadeRepository : IUnidadeRepository
    {
        private readonly BancoContext _context;
        public UnidadeRepository (BancoContext context) 
        {
            _context = context;
        }
        public UnidadeModel Cadastrar(UnidadeModel unidade)
        {
            var jaTemCnpj = _context.Unidades.FirstOrDefault(x => x.Cnpj == unidade.Cnpj && x.Ativo == true);
            if(jaTemCnpj != null)
            {
                throw new System.Exception("Cnpj já cadastrado!");
            }

            _context.Add(unidade);
            unidade.Ativo = true;
            unidade.DtCriacao = DateTime.Now;
            _context.SaveChanges();
            return unidade;
        }

        public bool Inativar(int id)
        {
            try
            {
                var unidade = _context.Unidades.Find(id);
                if (unidade == null) throw new System.Exception("Houve um erro ao inativar!");
                unidade.Ativo = false;
                _context.SaveChanges();
                return true;
            } catch (Exception e) 
            {
                return false;
            }
        }

        public IEnumerable<UnidadeModel> Listar()
        {
            return _context.Unidades.ToList().Where(x=>x.Ativo == true);
        }

        public UnidadeModel Obter(int id)
        {
            return _context.Unidades.Find(id);
        }

        public UnidadeModel Lstar()
        {
            return _context.Unidades.Find();
        }
    }
}
