using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympus
{
    [TestFixture]
    public class OlympusNUnitTests
    {
        public Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }


        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            var result = calc.AddNumbers(10, 20);

            //Assert
            Assert.AreEqual(30, result);

        }

        [Test]
        [TestCase(11)]
        public void IsOddChecker_InputOddNumber(int a)
        {
            Calculator checkInput = new();
            bool result = checkInput.IsInputOddNumber(a);
            Assert.That(result, Is.True);
        }


        [Test]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = false)]
        public bool IsInput_OddOrEvenNumber_ReturnTrueIfOdd(int a)
        {
            Calculator checkInput = new();
            return checkInput.IsInputOddNumber(a);
        }

        [Test]
        [TestCase(54.13, 43.22)]
        public void AddNumbers_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            Calculator calc = new();
            var result = calc.AddDoubleNumbers(a, b);
            Assert.AreEqual(97.349, result, 0.5);

        }

        [Test]

        public void CheckOddNumbers()
        {

            List<int> expectedOddRange = new() { 3, 5, 7, 9};
            List<int> rangedValues = calculator.GetOddNumbersRange(3,10);

            Assert.That(rangedValues, Is.EquivalentTo(expectedOddRange));
            Assert.That(rangedValues, Is.Unique);
            Assert.That(rangedValues, Does.Contain(3));
        }

        [Test]
        public void FiboRangeOfOne()
        {
            Fibo fibo = new Fibo();
            fibo.Range = 1;
            List<int> actual = new List<int> { 0 };
            List<int> values = fibo.GetFiboSeries();

            Assert.Multiple(() =>
            {
                Assert.That(values, Is.Not.Null.And.Not.Empty);
                Assert.That(values, Is.Ordered);
                Assert.That(values, Is.EquivalentTo(new[] { 0 }));
                Assert.That(values, Is.EqualTo(actual));
            });
        }

        [Test]
        public void FiboRangeOSix()
        {
            Fibo fibo = new Fibo();
            fibo.Range = 6;
            List<int> values = fibo.GetFiboSeries();

            Assert.Multiple(() =>
            {
                Assert.That(values, Does.Contain(3));
                Assert.That(values, Has.Count.EqualTo(6));
                Assert.That(values, Does.Not.Contain(4));
                Assert.That(values, Is.EquivalentTo(new[] { 0, 1, 1, 2, 3, 5 }));
            });

        }

    }
}
