using BankingWebApi.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Balance { get; set; } = 0;
        [StringLength(100), Required]
        public string Description { get; set; }


        public static bool Deposit(Account acct, decimal amount)
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
