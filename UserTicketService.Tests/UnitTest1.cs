namespace UserTicketService.Tests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Subtraction_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.That(calculator.Subtraction(300, 10) == 290);
    }

    [Test]
    public void Division_MustReturnCorrectValue()
    {
        var calculator = new Calculator();
        Assert.That(calculator.Division(200, 10) == 20);
    }

    [Test]
    public void Division_MustThrowException()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
    }
}
