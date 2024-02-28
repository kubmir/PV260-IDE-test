namespace IDE_Test_Library.Tests;

public class Tests
{
    private StringCalculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new StringCalculator();
    }

    [Test]
    public void Add_EmptyString_ReturnsZero()
    {
        var result = calculator.Add("");

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    [TestCase("", 0)]
    [TestCase("5", 5)]
    [TestCase("6", 6)]
    [TestCase("6,5", 11)]
    public void Add_OneNumber_ReturnTheSameNumber(String par, int expectedResult)
    {
        var result = calculator.Add(par);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
