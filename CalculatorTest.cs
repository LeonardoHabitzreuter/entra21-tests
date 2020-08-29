using Xunit;

namespace entra21_tests
{
    public class CalculatorTest
    {
        [Fact]
        public void should_return_4_when_passed_2_and_2()
        {
            var firstNumber = 2;
            var secondNumber = 2;
            var calculator = new Calculator();

            var result = calculator.Sum(firstNumber, secondNumber);

            var expectedOutput = 4;
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void should_return_0_when_passed_0_and_0()
        {
            var firstNumber = 0;
            var secondNumber = 0;
            var calculator = new Calculator();

            var result = calculator.Sum(firstNumber, secondNumber);

            var expectedOutput = 0;
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void should_return_8_dot_5_when_passed_8_and_0_dot_5()
        {
            var firstNumber = 0;
            var secondNumber = 0;
            var calculator = new Calculator();

            var result = calculator.Sum(firstNumber, secondNumber);

            var expectedOutput = 0;
            Assert.Equal(expectedOutput, result);
        }
        
        [Fact]
        public void should_return_2_when_passed_8_and_4()
        {
            var firstNumber = 8;
            var secondNumber = 4;
            var calculator = new Calculator();

            var result = calculator.Divide(firstNumber, secondNumber);

            var expectedOutput = 2;
            Assert.Equal(expectedOutput, result);
        }
        
        [Fact]
        public void should_return_0_when_passed_0_as_first_parameter()
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
