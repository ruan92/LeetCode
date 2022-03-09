using Xunit;

namespace _977_SquaresOfASortedArray.Tests
{
    public class TestCase
    {
        [Fact]
        public void Example1()
        {
            var algorithm = new Algorithm();
            var result = algorithm.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            Assert.Equal(new int[] { 0, 1, 9, 16, 100 }, result);
        }

        [Fact]
        public void Example2()
        {
            var algorithm = new Algorithm();
            var result = algorithm.SortedSquares(new int[] { -7, -3, 2, 3, 11 });
            Assert.Equal(new int[] { 4, 9, 9, 49, 121 }, result);
        }
    }
}