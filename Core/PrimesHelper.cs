using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public partial class PrimesHelper
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;                
            }               

            return true;
        }

        public static IEnumerable<int> GetPrimes(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (IsPrime(i)) yield return i;
            }
        }

        public static Table GetPrimesTable(int number)
        {
            var primes = GetPrimes(number).ToList();

            var rows = new List<IList<int>>();

            foreach(var prime in primes)
            {
                var row = new List<int>();
                
                foreach(var innerPrime in primes)
                {
                    row.Add(prime * innerPrime);
                }

                rows.Add(row);
            }

            return new Table
            {
                Primes = primes,
                Products = rows
            };
        }
    }
}
