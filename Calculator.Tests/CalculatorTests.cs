namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Addition(10, 220), Is.EqualTo(230));
        }

        [Test]
        public void SubstractionAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Subtraction(10, 5), Is.EqualTo(5));
        }

        [Test]
        public void MultiplicationAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Miltiplication(13, 10), Is.EqualTo(130));
        }

        [Test]
        public void DivisionAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Division(100, 20), Is.EqualTo(5));
        }
    }
}