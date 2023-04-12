using NUnit.Framework;
using Automation_Test;

namespace Automation_Test;

[TestFixture]

public class TestsDivide
{
    Calculator calculator;

    [OneTimeSetUp]
    public void SetupForClass()
    {
        calculator = new Calculator();
    }

    [TestCase(-12, -6, 2)]
    [TestCase(-400, -100, 4)]
    [TestCase(-190, -5, 38)]
    public void TestDivide_way1_negativeNumbers(int operand1, int operand2, int result)
    {
        //Action
        var actualResult = calculator.Divide(operand1, operand2);

        ////Assert
        Assert.That(actualResult, Is.EqualTo(result), $"Divide {operand1} / {operand2} = {actualResult}");
    }

    [TestCase(20, 1, ExpectedResult = 20)]
    [TestCase(306, 18, ExpectedResult = 17)]
    [TestCase(15000, 50, ExpectedResult = 300)]
    public int TestDivide_way2_positiveNumbers(int operand1, int operand2)
    {
        //Action
        var actualResult = calculator.Divide(operand1, operand2);

        return actualResult;
    }

    [Retry(2)]
    [Test]
    public void TestDivide_way3_mix(
        [Values(200, 800, 1400)] int operand1,
        [Range(-150, 500, 100)] int operand2)
    {
        //Action
        var actualResult = calculator.Divide(operand1, operand2);
        var expectedResult = operand1 / operand2;

        //Assert
        Assert.AreEqual(actualResult, expectedResult, $"Divide {operand1} / {operand2} = {actualResult}");
    }
}
