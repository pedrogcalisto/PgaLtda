using System.Linq;

namespace PGALtda.Models
{
    public class UnidadeDbSet : FakeDbSet<UnidadeModel>
    {
        public override UnidadeModel Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.Id == (int)keyValues.Single());
        }
    }
}
