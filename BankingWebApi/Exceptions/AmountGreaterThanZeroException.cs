using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Exceptions
{
    public class AmountGreaterThanZeroException : Exception
    {
        {
        public AmountGreaterThanZeroException() : base() { }
        public AmountGreaterThanZeroException(string Message) : base(Message) { }
        public AmountGreaterThanZeroException(string Message, Exception InnerException) : base(Message, InnerException) { }
    }
}
}
