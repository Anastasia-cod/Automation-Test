using NUnit.Framework;
using Automation_Test;

namespace Automation_Test;

[TestFixture]

public class TestsMultiply
{
    Calculator calculator;

    [OneTimeSetUp]
    public void SetupForClass()
    {
        calculator = new Calculator();
    }

    [TestCase(-12, -6, 72)]
    [TestCase(-400, -100, 40000)]
    [TestCase(-190, -5, 950)]
    public void TestMultiply_way1_negativeNumbers(int operand1, int operand2, int result)
    {
        //Action
        var actualResult = calculator.Multiply(operand1, operand2);

        ////Assert
        Assert.That(actualResult, Is.EqualTo(result), $"Multiply {operand1} * {operand2} = {actualResult}");
    }

    [TestCase(20, 1, ExpectedResult = 20)]
    [TestCase(306, 18, ExpectedResult = 5508)]
    [TestCase(15000, 50, ExpectedResult = 750000)]
    public int TestMultiply_way2_positiveNumbers(int operand1, int operand2)
    {
        //Action
        var actualResult = calculator.Multiply(operand1, operand2);

        return actualResult;
    }

    [Retry(2)]
    [Test]
    public void TestMultiply_way3_mix(
        [Values(17, 244, 3900)] int operand1,
        [Range(-200, 650, 50)] int operand2)
    {
        //Action
        var actualResult = calculator.Multiply(operand1, operand2);
        var expectedResult = operand1 * operand2;

        //Assert
        Assert.AreEqual(actualResult, expectedResult, $"Multiply {operand1} * {operand2} = {actualResult}");
    }
}
