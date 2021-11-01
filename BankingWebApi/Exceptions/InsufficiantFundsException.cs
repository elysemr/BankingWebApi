using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Exceptions
{
    public class InsufficiantFundsException : Exception
    {
        public decimal CurrentBalance { get; set; }
        public decimal AmountToWithdraw { get; set; }
        public InsufficiantFundsException(decimal CurrentBalance, decimal AmountToWithdraw) : base()
        {
            this.CurrentBalance = CurrentBalance;
            this.AmountToWithdraw = AmountToWithdraw;
        }
        public InsufficiantFundsException() : base() { }       //1 default
        public InsufficiantFundsException(string Message) : base(Message) { }      //1 with string
        public InsufficiantFundsException(string Message, Exception InnerException) : base(Message, InnerException) { }  //1 with the exception
    }
}
