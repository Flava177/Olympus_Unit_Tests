using NUnit.Framework;
using Olympus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympusGradeNUnitTest
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


        [Test]
        public void Get_B_AsGrade()
        {
            grading.Score = 85;
            grading.AttendancePercentage = 90;

            var result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("B"));
        }


        [Test]
        public void Get_C_AsGrade()
        {
            grading.Score = 65;
            grading.AttendancePercentage = 90;

            var result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("C"));
        }


        [Test]
        public void Get_B_AsGradeWIthLowAttendance()
        {
            grading.Score = 95;
            grading.AttendancePercentage = 65;

            var result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("B"));
        }

        [Test]
        [TestCase(95, 55)]
        [TestCase(55, 55)]
        [TestCase(50, 90)]
        public void GetGradeAsF_MulitpleTests(int a, int b)
        {
            grading.Score = a;
            grading.AttendancePercentage = b;

            var result = grading.GetGrade();
            Assert.That(result, Is.EqualTo("F"));
        }


        [TestCase(95, 90, ExpectedResult = "A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(55, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]
        public string TestAllGradesInOneUnitTest(int score, int attendance)
        {
            grading.Score = score;
            grading.AttendancePercentage = attendance;

            return grading.GetGrade();
            
        }

    }
}
