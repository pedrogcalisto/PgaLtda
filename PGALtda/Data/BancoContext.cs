using Microsoft.EntityFrameworkCore;
using PGALtda.Models;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace PGALtda.Data
{
    public class BancoContext : DbContext, IBancoContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        public virtual IDbSet<UnidadeModel> Unidades { get; set; }
        public virtual IDbSet<FuncionarioModel> Funcionarios { get; set; }
        public virtual IDbSet<FuncionarioUnidadeModel> FuncionarioUnidade { get; set; }
    }
}
