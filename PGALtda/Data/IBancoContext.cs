using Microsoft.EntityFrameworkCore;
using PGALtda.Models;
using System.Data.Entity;

namespace PGALtda.Data
{
    public interface IBancoContext 
    {
        public IDbSet<UnidadeModel> Unidades { get; set; }
        public IDbSet<FuncionarioModel> Funcionarios { get; set; }
        public IDbSet<FuncionarioUnidadeModel> FuncionarioUnidade { get; set; }
        public int SaveChanges();

    }
}
