using System.Linq;

namespace PGALtda.Models
{
    public class FuncionarioDbSet : FakeDbSet<FuncionarioModel>
    {
        public override FuncionarioModel Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.Id == (int)keyValues.Single());
        }
    }
}
