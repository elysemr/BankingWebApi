using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Models
{
    public class BankDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }


        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
