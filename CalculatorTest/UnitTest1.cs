using System;
using Xunit;
using Calculator;

namespace CalculatorTest
{
    public class SumTest
    {
        [Theory]
        [InlineData(8, 10, 18)]
        [InlineData(-15, -16, -31)]
        public void PositivSumTest(int a, int b, int expected)
        {
            int actual = Calc.Sum(a, b);
            Assert.Equal(expected, actual);
        }
    }
    public class DifferenceTest
    {
        [Theory]
        [InlineData(8, 10, -2)]
        [InlineData(-15, -16, 1)]
        public void PositivDifferenceTest(int a, int b, int expected)
        {
            int actual = Calc.Difference(a, b);
            Assert.Equal(expected, actual);
        }
    }
    public class MultiplicationTest
    {
        [Theory]
        [InlineData(8, 10, 80)]
        [InlineData(-15, -16, 240)]
        public void PositivMultiplicationTest(int a, int b, int expected)
        {
            int actual = Calc.Multiplication(a, b);
            Assert.Equal(expected, actual);
        }
    }
    public class DivisionTest
    {
        [Theory]
        [InlineData(80, 10, 8)]
        [InlineData(-150, -15, 10)]
        public void PositivDivisionTest(int a, int b, int expected)
        {
            int actual = Calc.Division(a, b);
            Assert.Equal(expected, actual);
        }
    }
    public class DivisionTestNeg
    {
        [Fact]
        public void NegativDivisionTest()
        {
            int a = 10;
            int b = 0;
            Action action = () => Calc.Division(a, b);
            Assert.Throws<DivideByZeroException>(action);
        }
    }
    public class SquareTest
    {
        [Theory]
        [InlineData(81, 9)]
        [InlineData(144, 12)]
        public void PositivSquareTest(int a, int expected)
        {
            int actual = Calc.Square(a);
            Assert.Equal(expected, actual);
        }
    }
    public class SquareTestNeg
    {
        [Fact]
        public void NegativSquareTest()
        {
            int a = -16;
            Action action = () => Calc.Square(a);
            Assert.Throws<ArgumentException>(action);
        }
    }
    public class CheckIntTest
    {

        [Theory]   
        [InlineData("gg")]
        public void NegativCheckIntTest(string a)
        {
            
            Action action = () => Program.CheckToInt(a, out int value);
            Assert.Throws<ArgumentException>(action);
        }
    }
}
