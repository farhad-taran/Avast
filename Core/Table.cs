using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public partial class PrimesHelper
    {
        public class PrimesTable
        {
            public IList<int> Primes { get; set; }
            public IList<IList<int>> Products { get; set; }

            public override string ToString()
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.Append("\t");
                foreach (var prime in Primes)
                    stringBuilder.Append(prime + "\t");
                stringBuilder.AppendLine();
                var rowId = 0;
                foreach( var row in Products)
                {
                    stringBuilder.Append(Primes[rowId] + "\t");
                    rowId++;
                    foreach (var column in row)
                    {
                        stringBuilder.Append(column + "\t");
                    }
                    stringBuilder.AppendLine();
                }
                return stringBuilder.ToString();
            }
        }
    }
}
