using NUnit.Framework;
using Automation_Test;

namespace Automation_Test;

[TestFixture]

public class TestSumm
{
    Calculator calculator;

    [OneTimeSetUp]
    public void SetupForClass()
    {
        calculator = new Calculator();
    }

    [TestCase(-2, -6, -8)]
    [TestCase(-4, -10, -14)]
    [TestCase(-1, -19, -20)]
    public void TestSumm_way1_negativeNumbers(int operand1, int operand2, int result)
    {
        //Action
        var actualResult = calculator.Summ(operand1, operand2);

        ////Assert
        Assert.That(actualResult, Is.EqualTo(result), $"Summ {operand1} + {operand2} = {actualResult}");
    }

    [TestCase(1, 2, ExpectedResult = 3)]
    [TestCase(35, 18, ExpectedResult = 53)]
    [TestCase(125, 460, ExpectedResult = 585)]
    public int TestSumm_way2_positiveNumbers(int operand1, int operand2)
    {
        //Action
        var actualResult = calculator.Summ(operand1, operand2);

        return actualResult;
    }

    [Test]
    public void TestSumm_way3_mix(
        [Values(9 ,38 ,179)] int operand1,
        [Range(-15, 29, 5)] int operand2)
    {
        //Action
        var actualResult = calculator.Summ(operand1, operand2);
        var expectedResult = operand1 + operand2;

        //Assert
        Assert.AreEqual(actualResult, expectedResult, $"Summ {operand1} + {operand2} = {actualResult}");
    }
}
