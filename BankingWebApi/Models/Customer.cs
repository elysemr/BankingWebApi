using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingWebApi.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [StringLength(30), Required]
        public string Firstname { get; set; }
        [StringLength(30), Required]
        public string Lastname { get; set; }
        [StringLength(30), Required]
        public string Username { get; set; }
        [StringLength(30), Required]
        public string Password { get; set; }
        [StringLength(100), Required]
        public string Address { get; set; }
        [StringLength(50), Required]
        public string City { get; set; }
        [StringLength(2), Required]
        public string State { get; set; }
        [StringLength(5), Required]
        public string Zip { get; set; }
        [StringLength(255)]
        public string Email { get; set; }



        public Customer () { }

    }
}
