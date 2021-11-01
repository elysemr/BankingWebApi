using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Models
{
    public class Savings : Account
    {
        public decimal InterestRate { get; set; } = 0.02m;
        public int CustomerId { get; set; }
        public virtual Customer customer { get; set; }

        public decimal CalculateAndPayInterest (int months)
        {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
            return interest;

        }



    }
}
