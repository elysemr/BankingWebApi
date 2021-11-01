using BankingWebApi.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public static bool Deposit(Account acct, decimal amount)
        {
            if (amount <= 0)
            {
                throw new AmmountGreaterThanZeroException();
            }
            acct.Balance += amount;
            return true;
        }
        public static bool Withdraw(Account acct, decimal amount)
        {
            if (amount <= 0)
            {
                throw new AmmountGreaterThanZeroException();
            }
            if (amount > acct.Balance)
            {
                throw new InsufficiantFundsException(acct.Balance, amount);   //This.Balance takes Balance and puts it in CurrentBalance property in InsufficiantFundsException
            }
            acct.Balance -= amount;
            return true;
        }
        public bool Transfer(Account from, decimal amount, Account ToAccount)   //Takes Account class and puts in ToAccount to access inside of Transfer method
        {
            if (amount <= 0)
            {
                throw new AmmountGreaterThanZeroException();
            }
            var success = Withdraw(from, amount);
            if (success)
            {
                Deposit(ToAccount, amount);
                return true;
            }
            return false;
        }
    }
}
