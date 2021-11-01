﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingWebApi.Models;

namespace BankingWebApi.Models
{
    public class BankDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }


        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }

        public DbSet<BankingWebApi.Models.Savings> Savings { get; set; }
    }
}
