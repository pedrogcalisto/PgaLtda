using PGALtda.Data;
using PGALtda.Models;
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
            _context.SaveChanges();
            return unidade;
        }

        public void Inativar(int id)
        {
            var unidade = _context.Unidades.FirstOrDefault(x => x.Id == id && x.Ativo == true);
            if (unidade == null) throw new System.Exception("Houve um erro ao inativar!");
            unidade.Ativo = false;
            _context.SaveChanges();
        }

        public IEnumerable<UnidadeModel> Listar()
        {
            return _context.Unidades.ToList().Where(x=>x.Ativo == true);
        }

        public UnidadeModel Obter(int id)
        {
            return _context.Unidades.FirstOrDefault(x=>x.Id == id);
        }
    }
}
