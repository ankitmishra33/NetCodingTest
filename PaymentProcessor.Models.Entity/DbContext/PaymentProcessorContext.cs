using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PaymentProcessor.Models.Entity
{
    public class PaymentProcessorContext : DbContext
    {
        public PaymentProcessorContext(DbContextOptions<PaymentProcessorContext> options) : base(options) 
        {   
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                      
        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentState> PaymentStates { get; set; }
    }
}
