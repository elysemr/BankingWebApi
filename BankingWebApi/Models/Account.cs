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
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new AmmountGreaterThanZeroException();
            }
            this.Balance = this.Balance + amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new AmmountGreaterThanZeroException();
            }
            if (amount > this.Balance)
            {
                throw new InsufficiantFundsException(this.Balance, amount);   //This.Balance takes Balance and puts it in CurrentBalance property in InsufficiantFundsException
            }
            this.Balance = this.Balance - amount;
            return true;
        }
        public bool Transfer(decimal amount, Account ToAccount)   //Takes Account class and puts in ToAccount to access inside of Transfer method
        {
            if (amount <= 0)
            {
                throw new AmmountGreaterThanZeroException();
            }
            var success = Withdraw(amount);
            if (success)
            {
                ToAccount.Deposit(amount);
                return true;
            }
            return false;
        }
    }
}
