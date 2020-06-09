using Xunit;

namespace Core.Tests
{
    public class PrimeHelperTests
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        [InlineData(12, false)]
        [InlineData(13, true)]
        public void IsPrime_ReturnsCorrectValue(int number, bool expectedResult)
        {
            Assert.Equal(expectedResult, PrimesHelper.IsPrime(number));
        }

        [Fact]
        public void GetPrimes_ReturnsPrimeNumbersUptoAndIncludingInput()
        {
            var expectedResult = new[] { 2, 3, 5, 7, 11, 13 };

            var actualResult = PrimesHelper.GetPrimes(13);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetPrimesTable_ReturnsTableWithCorrectPrimeNumbers()
        {
            var actualResult = PrimesHelper.GetPrimesTable(3);

            Assert.Equal(actualResult.Primes, new[] { 2, 3 });
        }

        [Fact]
        public void GetPrimesTable_ReturnsTableWithCorrectPrimeNumbersProducts()
        {
            var actualResult = PrimesHelper.GetPrimesTable(13);

            int rowId = 0;
            int columnId = 0;
            foreach (var row in actualResult.Products)
            {
                foreach (var column in row)
                {
                    Assert.Equal(column, actualResult.Primes[rowId] * actualResult.Primes[columnId]);

                    columnId++;
                }
                columnId = 0;
                rowId++;
            }

        }
    }
}
