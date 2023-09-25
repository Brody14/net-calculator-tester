using net_calculator_tester;
using System.IO;

namespace TestCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        [TestCase(4, 3, 7)]
        [TestCase(-5, 2, -3)]
        [TestCase(1.5f, 0.5f, 2)]

        public void TestSum(float num1, float num2, float result)
        {
            float summed = Calculator.Add(num1, num2);
            Assert.IsTrue(summed == result);
      
        }

        [Test]
        [TestCase(4, 3, 1)]
        [TestCase(5, 6, -1)]
        [TestCase(1.5f, 0.5f, 1)]

        public void TestSubtract(float num1, float num2, float result)
        {
            float subtracted = Calculator.Subtract(num1, num2);
            Assert.IsTrue(subtracted == result);

        }

        [Test]
        [TestCase(21, 7, 3)]
        [TestCase(-5, 2, -2.5f)]
        [TestCase(20.5f, 5, 4.1f)]

        public void TestDivision(float num1, float num2, float result)
        {
            float divided = Calculator.Divide(num1, num2);
            Assert.IsTrue(divided == result);

        }

        [Test]
        [TestCase(7, 3, 21)]
        [TestCase(4, 2, 8)]
        [TestCase(4.1f, 5, 20.5f)]

        public void TestMultiply(float num1, float num2, float result)
        {
            float multiplied = Calculator.Multiply(num1, num2);
            Assert.IsTrue(multiplied == result);

        }

        [Test]
        public void TestDivision_Fail()
        {
            Assert.Throws<Exception>(() => Calculator.Divide(5,0));

        }
    }
}