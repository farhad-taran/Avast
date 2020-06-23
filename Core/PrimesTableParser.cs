using System.Text;

namespace Core
{
    public static class PrimesTableParser
    {
        public static string ParseToString(PrimesTable primesTable)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\t");
            foreach (var prime in primesTable.Primes)
                stringBuilder.Append(prime + "\t");
            stringBuilder.AppendLine();
            var rowId = 0;
            foreach (var row in primesTable.Products)
            {
                stringBuilder.Append(primesTable.Primes[rowId] + "\t");
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