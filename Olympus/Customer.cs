﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympus
{
    public class Customer
    {
        public int Discount = 15;
        public int OrderTotal { get; set; }
        public string GreetMessage { get; set; }
        public string CombineFirstLastNameAsFullName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Empty first name");
            }

            GreetMessage =  $"Hello, {firstName} {lastName}";
            Discount = 20;
            return GreetMessage;
        }

        public CustomerType GetCustomerDetails()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
                return new PlatinumCustomer();
        }
    }

    public class CustomerType{ }
    public class BasicCustomer : CustomerType { }
    public class PlatinumCustomer : CustomerType { }
}
