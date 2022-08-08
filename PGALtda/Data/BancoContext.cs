using Microsoft.EntityFrameworkCore;
using PGALtda.Models;

namespace PGALtda.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        public DbSet<UnidadeModel> Unidades { get; set; }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
