using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public partial class PrimesHelper
    {
        private static readonly HashSet<int> Primes = new HashSet<int>();
        private static readonly HashSet<int> NonPrimes = new HashSet<int>();

        public static bool IsPrime(int number)
        {
            if (NonPrimes.Contains(number)) return false;
            if (Primes.Contains(number)) return true;
            if (number <= 1) return false;
            if (number == 2) return true;
            
            if (number % 2 == 0)
            {
                NonPrimes.Add(number);
                return false;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    NonPrimes.Add(number);
                    return false;
                }
            }

            Primes.Add(number);

            return true;
        }

        public static IEnumerable<int> GetPrimesUpTo(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (IsPrime(i)) yield return i;                
            }
        }

        public static PrimesTable GetPrimesTable(int number)
        {
            var primes = GetPrimesUpTo(number).ToList();

            var rows = new List<IList<int>>();

            foreach (var prime in primes)
            {
                var row = new List<int>();

                foreach (var innerPrime in primes)
                {
                    row.Add(prime * innerPrime);
                }

                rows.Add(row);
            }

            return new PrimesTable
            {
                Primes = primes,
                Products = rows
            };
        }
    }
}
