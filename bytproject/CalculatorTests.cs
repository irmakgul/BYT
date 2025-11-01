using NUnit.Framework;
using Tut2_s20123;

namespace Tut2_s20123_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var calc = new Calculator(10, 5, '+');
            Assert.That(calc.Compute(), Is.EqualTo(15));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            var calc = new Calculator(10, 5, '-');
            Assert.That(calc.Compute(), Is.EqualTo(5));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var calc = new Calculator(10, 5, '*');
            Assert.That(calc.Compute(), Is.EqualTo(50));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            var calc = new Calculator(10, 5, '/');
            Assert.That(calc.Compute(), Is.EqualTo(2));
        }

        [Test]
        public void Divide_ByZero_Throws()
        {
            var calc = new Calculator(10, 0, '/');
            Assert.Throws<DivideByZeroException>(() => calc.Compute());
        }

        [Test]
        public void InvalidOperator_ThrowsArgumentException()
        {
            var calc = new Calculator(10, 5, '%');
            Assert.Throws<ArgumentException>(() => calc.Compute());
        }

        [Test]
        public void Works_With_NegativeNumbers()
        {
            var calc = new Calculator(-3, -7, '+');
            Assert.That(calc.Compute(), Is.EqualTo(-10));
        }

        [Test]
        public void Works_With_FloatingValues()
        {
            var calc = new Calculator(7.5, 2.5, '/');
            Assert.That(calc.Compute(), Is.EqualTo(3).Within(0.0001));
        }
    }
}