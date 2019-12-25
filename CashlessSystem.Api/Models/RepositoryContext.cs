using CashlessSystem.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashlessSystem.Api
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) :base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventPhoto> EventPhotos { get; set; }
        public DbSet<EventTermsAndCondition> EventTermsAndConditions { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserOrderHistory> UserOrderHistories { get; set; }
        public DbSet<UserPaymentMethod> UserPaymentMethods { get; set; }
        public DbSet<UserPaymentMethodDetail> UserPaymentMethodDetails { get; set; }
        public DbSet<UserTransactionHistory> UserTransactionHistories { get; set; }
    }
}
