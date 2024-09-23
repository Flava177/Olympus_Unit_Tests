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

    }
}
