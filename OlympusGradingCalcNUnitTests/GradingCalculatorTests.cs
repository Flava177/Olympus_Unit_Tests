using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympus
{
    [TestFixture]
    public class GradingCalculatorTests
    {
        public GradingCalculator grading;
        [SetUp]
        public void SetUp()
        {
            grading = new GradingCalculator();
        }

        [Test]
        public void Get_A_AsGrade()
        {
            grading.Score = 95;
            grading.AttendancePercentage = 90;

            var result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("A"));
        }

    }
}
