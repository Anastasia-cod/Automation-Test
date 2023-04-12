using NUnit.Framework;
using Automation_Test;

namespace Automation_Test;

[TestFixture]

public class TestsMinus
{
    Calculator calculator;

    [SetUp]
    public void SetupForEachMethod()
    {
        calculator = new Calculator();
    }

    [TestCase(-2, -6, 4)]
    [TestCase(-40, -101, 61)]
    [TestCase(-19, -8, -11)]
    public void TestMinus_way1_negativeNumbers(int operand1, int operand2, int result)
    {
        //Action
        var actualResult = calculator.Minus(operand1, operand2);

        ////Assert
        Assert.That(actualResult, Is.EqualTo(result), $"Minus {operand1} - {operand2} = {actualResult}");
    }

    [TestCase(1, 2, ExpectedResult = -1)]
    [TestCase(35, 18, ExpectedResult = 17)]
    [TestCase(125, 460, ExpectedResult = -335)]
    public int TestMinus_way2_positiveNumbers(int operand1, int operand2)
    {
        //Action
        var actualResult = calculator.Minus(operand1, operand2);

        return actualResult;
    }

    [Retry(2)]
    [Test]
    public void TestMinus_way3_mix(
        [Values(78, 1500, 179)] int operand1,
        [Range(-150, 120, 35)] int operand2)
    {
        //Action
        var actualResult = calculator.Minus(operand1, operand2);
        var expectedResult = operand1 - operand2;

        //Assert
        Assert.AreEqual(actualResult, expectedResult, $"Minus {operand1} - {operand2} = {actualResult}");
    }
}
