using PGALtda.Models;
using System.Data.Entity;

namespace PGALtda.Data
{
    public class MockContext : IBancoContext
    {
        public MockContext()
        {
            this.Funcionarios = new FuncionarioDbSet();
        }

        public IDbSet<UnidadeModel> Unidades { get; set; }
        public IDbSet<FuncionarioModel> Funcionarios { get; set; }
        public IDbSet<FuncionarioUnidadeModel> FuncionarioUnidade { get; set ; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
