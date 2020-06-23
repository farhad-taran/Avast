using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class PrimesTable
    {
        public IList<int> Primes { get; set; }
        public IList<IList<int>> Products { get; set; }
    }
}
