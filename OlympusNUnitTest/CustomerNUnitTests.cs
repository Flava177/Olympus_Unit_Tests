using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympus
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        public Customer customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        public void CombineTwoStringsForFullName()
        {
            customer.CombineFirstLastNameAsFullName("Daniel", "Adjei");
            Assert.Multiple(() =>
            {
                Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Daniel Adjei"));
                Assert.That(customer.GreetMessage, Does.Contain("1Hello"));
                Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
                Assert.That(customer.GreetMessage, Does.StartWith("1Hello"));
            });
           
        }

        [Test]
        public void CheckGreetMessageIsNull()
        {
            Assert.IsNull(customer.GreetMessage);
        }

        [Test]
        public void ReturnExceptionIfNoFirstName()
        {
            customer.CombineFirstLastNameAsFullName("ben", "");

            Assert.IsNotNull(customer.GreetMessage);
            Assert.IsFalse(string.IsNullOrWhiteSpace(customer.GreetMessage));
        }

        [Test]
        public void GreetMessageThrowsExceptionEmptyFirstName()
        {
            var exceptionDetails = Assert.Throws<ArgumentException>(() =>
            {
                customer.CombineFirstLastNameAsFullName("", "Manu");
            });
            Assert.AreEqual("Empty first name", exceptionDetails.Message);
        }

        //testing for type of customer
        [Test]
        public void GetCustomerTypeWithOrderDetails()
        {
            customer.OrderTotal = 199;
            var result = customer.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<BasicCustomer>());
        }
    }
}
