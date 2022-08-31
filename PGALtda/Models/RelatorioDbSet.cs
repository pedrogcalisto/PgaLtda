using System.Linq;

namespace PGALtda.Models
{
    public class RelatorioDbSet : FakeDbSet<FuncionarioUnidadeModel>
    {
        public override FuncionarioUnidadeModel Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.Id == (int)keyValues.Single());
        }
    }
}
