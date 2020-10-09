using Xunit;
using Domain;

namespace Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(0, 0, 0)]
        [InlineData(8, 0.5, 8.5)]
        [InlineData(-2, 2, 0)]
        [InlineData(-2.5, -3.5, -6)]
        public void Should_return_the_result_of_the_sum_between_2_parameters(double firstNumber, double secondNumber, double expected)
        {
            var calculator = new Calculator();

            var result = calculator.Sum(firstNumber, secondNumber);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_return_2_when_passed_8_and_4()
        {
            const int firstNumber = 8;
            const int secondNumber = 4;
            var calculator = new Calculator();

            var result = calculator.Divide(firstNumber, secondNumber);

            var expectedOutput = 2;
            Assert.Equal(expectedOutput, result);
        }
        
        [Fact]
        public void Should_return_0_when_passed_0_as_first_parameter()
        {
            var firstNumber = 0;
            var secondNumber = 6;
            var calculator = new Calculator();

            var result = calculator.Divide(firstNumber, secondNumber);

            var expectedOutput = 0;

            Assert.Equal(expectedOutput, result);
        }
    }
}
