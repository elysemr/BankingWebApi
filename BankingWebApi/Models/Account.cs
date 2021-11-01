using BankingWebApi.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Models
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; }

        public Account(int id, decimal balance, string description)
        {
            Id = id;
            Balance = balance;
            Description = description;
        }
        public Account() { }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new AmountGreaterThanZeroException();
            }
            this.Balance = this.Balance + amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new InsufficientFundsException(this.Balance, amount);
            }
            if (amount <= 0)
            {
                throw new AmountGreaterThanZeroException();
            }
            this.Balance = this.Balance - amount;
            return true;
        }
        public bool Transfer(decimal amount, Account ToAccount)
        {
            var success = Withdraw(amount);
            if (success == true) //or if success
            {
                ToAccount.Deposit(amount);
                return true;
            }

            return false;
        }
        public void Print()
        {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }
}
