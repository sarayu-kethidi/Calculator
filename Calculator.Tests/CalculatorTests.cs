namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(1, -2, -1)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(0, -1, -1)]
        public void Add_Tests(int a, int b, int expected)
        {
            int sum = Calculator.Core.Calculator.Add(a, b);
            Assert.Equal(expected, sum);
        }

        [Fact]
        public void Add_ShouldThrowException()
        {

            Assert.Throws<System.OverflowException>(() => Calculator.Core.Calculator.Add(int.MaxValue, 2));
        }
        [Fact]
        public void Divide_BaseCase()
        {
            double result = Calculator.Core.Calculator.Divide(2, 1);
            Assert.Equal(2.0, result, 1);
        }
        [Fact]
        public void Divide_ShouldThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => Calculator.Core.Calculator.Divide(2, 0));
        }
        [Fact]
        public void Multiply_BaseCase()
        {
            float result = Calculator.Core.Calculator.Multiply(2, 3);
            Assert.Equal(6.0f, result);
        }
        [Fact]
        public void Multiply_Zero()
        {
            float result = Calculator.Core.Calculator.Multiply(2, 0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_ShouldThrowException()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Core.Calculator.Multiply(int.MaxValue, float.MaxValue));
        }
        [Fact]
        public void Subtract_BaseCase()
        {
            int difference = Calculator.Core.Calculator.Subtract(3, 2);
            Assert.Equal(1, difference);
        }
        [Fact]
        public void Subtract_FromZero()
        {
            int difference = Calculator.Core.Calculator.Subtract(0, 2);
            Assert.Equal(-2, difference);
        }
        [Fact]
        public void Subtract_Equal()
        {
            int difference = Calculator.Core.Calculator.Subtract(2, 2);
            Assert.Equal(0, difference);
        }
        [Fact]
        public void Subtract_Negatives()
        {
            int difference = Calculator.Core.Calculator.Subtract(-5, -6);
            Assert.Equal(1, difference);
        }
        [Fact]
        public void Subtract_NegativePositive()
        {
            int difference = Calculator.Core.Calculator.Subtract(-6, 5);
            Assert.Equal(-11, difference);
        }

    }
}