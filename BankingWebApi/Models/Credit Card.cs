﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Models
{
    public class CreditCard : Account
    {
        [Column(TypeName = "decimal(9,2)")]
        public decimal Intrest { get; set; } = 02.62m;
        [Column(TypeName = "decimal(9,2)")]
        public decimal intrestowed { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer customer { get; set; }
        

        public CreditCard(int months)
        {
            intrestowed = Balance * (Intrest / 12) * months;
        }
        public CreditCard() { }
        
    }
}
