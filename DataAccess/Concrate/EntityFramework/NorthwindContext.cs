using Core.Entities.Concrete;
using Entities;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class NorthwindContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-0VUERDH\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
